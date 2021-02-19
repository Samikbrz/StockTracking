using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shelf : IEntity
    {
        public int ShelfId { get; set; }
        public string ShelfName { get; set; }

        public int CurrentStoreId { get; set; }
        public Store Store { get; set; }

        public ICollection<Drawer> Drawers { get; set; }
        public ICollection<StockStore> StockStores { get; set; }
        public ICollection<StoreTransfer> StoreTransfers { get; set; }
    }
}
