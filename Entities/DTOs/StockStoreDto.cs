using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StockStoreDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public char Currency { get; set; }
        public string Barcode { get; set; }
        public string StoreName { get; set; }
        public string ShelfName { get; set; }
        public string DrawerName { get; set; }
        public int Count { get; set; }
    }
}
