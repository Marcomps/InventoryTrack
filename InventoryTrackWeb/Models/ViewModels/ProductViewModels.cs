using Microsoft.Build.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryTrackWeb.Models.ViewModels
{
    public class ProductViewModels
    {
        //public ProductViewModels()
        //{
        //    PreSales = new HashSet<PreSale>();
        //    Sales = new HashSet<Sale>();
        //}

        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        public int? Stock { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Costo Unitario"), DataType(DataType.Currency)]
        public decimal UnitCost { get; set; }

        [Display(Name = "Costo de venta"), DataType(DataType.Currency)]
        public decimal UnitCostSale { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Total { get; set; }

        //[NotMapped]
        [DataType(DataType.Date), Display(Name = "Fecha"), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? Date { get; set; }

        public virtual ICollection<PreSale> PreSales { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
