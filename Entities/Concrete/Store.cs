using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Store : IEntity
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public bool IsSalesStore { get; set; }

        public int StoreOfStockStoreId { get; set; }
        public StockStore StockStore { get; set; }

        public int StoreOfStoreTranferId { get; set; }
        public StoreTransfer StoreTransfer { get; set; }

        public ICollection<Shelf> Shelves { get; set; }
        public ICollection<StoreTransfer> StoreTransfers { get; set; }
    }
}
