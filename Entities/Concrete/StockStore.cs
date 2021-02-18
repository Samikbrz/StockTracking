using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockStore : IEntity
    {
        public int StockStoreId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public char Currency { get; set; } 
        public string Barcode { get; set; }       
        public int Count { get; set; }

        public Store Store { get; set; }

        public int CurrentShelfId { get; set; }
        public Shelf Shelf { get; set; }

        public int CurrentDrawerId { get; set; }
        public Drawer Drawer { get; set; }
    }
}
