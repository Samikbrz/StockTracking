using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockStore : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public char Currency { get; set; } 
        public string Barcode { get; set; }       
        public int Count { get; set; }
        public int ShelfId { get; set; }
        public int DrawerId { get; set; }
    }
}
