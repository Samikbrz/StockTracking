using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Drawer : IEntity
    {
        public int DrawerId { get; set; }
        public string DrawerName { get; set; }

        public int CurrentShelfId { get; set; }
        public Shelf Shelf { get; set; }

        public ICollection<StockStore> StockStores { get; set; }
        public ICollection<StoreTransfer> StoreTransfers { get; set; }
    }
}
