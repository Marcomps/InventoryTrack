﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace InventoryTrackWeb.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Unit { get; set; }
        public decimal? UnitCostSale { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Date { get; set; }

        public virtual Product Product { get; set; }
    }
}