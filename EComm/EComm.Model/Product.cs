﻿using System.ComponentModel;

namespace EComm.Model
{
    public class Product
    {
        public int Id { get; set; }

        //[DisplayName("Product")]
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
