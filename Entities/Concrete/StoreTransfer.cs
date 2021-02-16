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
        public string StoreName { get; set; }
        public string ShelfName { get; set; }
        public string DrawerName { get; set; }
        public string TargetStore { get; set; }
        public string TargetShelf { get; set; }
        public string TargetDrawer { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
