using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransferTargetDrawer
    {
        public int StockStoreId { get; set; }
        public StockStore StockStore { get; set; }

        public int TargetDrawerId { get; set; }
        public Drawer TargetDrawer { get; set; }
    }
}
