using System.ComponentModel.DataAnnotations;

namespace InventoryTrackWeb.Models.ViewModels
{
    public class ProductViewModels
    {
        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [RegularExpression("^([0-9]+)$", ErrorMessage = "Ingrese un numero")]
        public int? Stock { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Costo Unitario"), DataType(DataType.Currency)]
        public decimal UnitCost { get; set; }

        [Display(Name = "Costo de venta"), DataType(DataType.Currency)]
        public decimal UnitCostSale { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Total { get; set; }

        [DataType(DataType.Date), Display(Name = "Fecha"), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? Date { get; set; }
        [Display(Name = "Costo Total de Venta"), DataType(DataType.Currency)]
        public decimal? CostSaleTotal { get; set; }

        public virtual ICollection<PreSale> PreSales { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
