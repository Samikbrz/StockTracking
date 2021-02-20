using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransferDrawer
    {
        public int StockStoreId { get; set; }
        public StockStore StockStore { get; set; }

        public int DrawerId { get; set; }
        public Drawer Drawer { get; set; }
    }
}
