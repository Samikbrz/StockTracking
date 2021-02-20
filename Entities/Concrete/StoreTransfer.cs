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
        public Store Store { get; set; }
        public Store TargetStore { get; set; }

        public IList<StoreTransferDrawer> StoreTransferDrawers { get; set; }
        public IList<StoreTransferTargetDrawer> StoreTransferTargetDrawers { get; set; }
        public IList<StoreTransferShelf> StoreTransferShelves { get; set; }
        public IList<StoreTransferTargetShelf> StoreTransferTargetShelves { get; set; }
    }
}
