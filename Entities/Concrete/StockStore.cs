using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockStore : IEntity
    {
        public int Id { get; set; }
        public int ProductAcceptanceId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Currency { get; set; } 
        public string Barcode { get; set; }       
        public int StoreId { get; set; }
        public int ShelfId { get; set; }
        public int DrawerId { get; set; }
        public int Count { get; set; }
    }
}
