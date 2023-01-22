using InventoryTrackWeb.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using InventoryTrackWeb.Models;
using InventoryTrackWeb.Models.Context;
using System.Data;
using System.Net;
using AutoMapper;
using InventoryTrackWeb.Models.ViewModels;
using System.Diagnostics;
using System.Xml;

namespace NewDesktopWeb.Controllers
{
    public class ProductController : Controller 
    {
        InventoryTrackTestContext db = new InventoryTrackTestContext();
        InventoryTrackTestContext context;
        object dbe = new InventoryTrackTestContext();
        DbContext dbContext;

        //private readonly IMapper _mapper;
         private readonly IMapper _mapper;

        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: Product
        public ActionResult List()
        {
            using (var db = new InventoryTrackTestContext())
            {
                ProductViewModels product = new ProductViewModels();
                List<ProductViewModels> prodList = _mapper.Map<List<ProductViewModels>>(db.Products.ToList());
                return View(prodList);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            // GemaInventoryTrackTestContext db = new GemaInventoryTrackTestContext();

            //return View(db.Products.Where(p => p.ProductId == id));
            //return View(db.Products.Find(id));
            using (var db = new InventoryTrackTestContext())
            {
                //var blogs = db.Products
                //    .ToList();
                return View(db.Products.Find(id));
            }
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModels collection)
        {
            if (collection.Date == null)
            {
                var test = $"atat {DateTime.Now:d}";
                Debug.WriteLine("Imprimiento test de fecha ",test);
                collection.Date = DateTime.Today;
            }

            using (var db = new InventoryTrackTestContext())
            {
                try
                {
                    db.Products.Add(_mapper.Map<Product>(collection));
                    db.SaveChanges();
                    return RedirectToAction(nameof(List));
                }
                catch (Exception)
                {
                    return View();
                }
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            using (var db = new InventoryTrackTestContext())
            {
                var product = _mapper.Map<ProductViewModels>(db.Products.Find(id));
                //return View(product);
                //return View(db.Products.Find(id));
                return View(_mapper.Map<ProductViewModels>(db.Products.Find(id)));
            }
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, ProductViewModels collection)
        {
            using (var db = new InventoryTrackTestContext())
            {
                var productEntity = _mapper.Map<Product>(collection);
                db.Entry(productEntity).State = EntityState.Modified;
                db.Set<Product>().Update(productEntity);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(List));
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (var db = new InventoryTrackTestContext())
            {
                return View(db.Products.Find(id));
            }
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            using (var db = new InventoryTrackTestContext())
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                try
                {
                    return RedirectToAction(nameof(List));
                }
                catch
                {
                    return View();
                }
            }
        }
    }
}
