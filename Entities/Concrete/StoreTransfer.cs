using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransfer : IEntity
    {
        public int StoreTransferId { get; set; }
        public string TransferNo { get; set; }        
        public DateTime Date { get; set; }
        public string UserName { get; set; }

        public int CurrentStoreId { get; set; }
        public Store StoreName { get; set; }
        public int CurrentShelfId { get; set; }
        public Shelf ShelfName { get; set; }
        public int CurrentDrawerId { get; set; }
        public Drawer DrawerName { get; set; }
        public int CurrentTargetStoreId { get; set; }
        public Store TargetStore { get; set; }
        public int CurrentTargetShelfId { get; set; }
        public Shelf TargetShelf { get; set; }
        public int CurrentTargetDrawerId { get; set; }
        public Drawer TargetDrawer { get; set; }
    }
}
