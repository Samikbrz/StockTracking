using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransferTargetShelf
    {
        public int StockStoreId { get; set; }
        public StockStore StockStore { get; set; }

        public int TargetShelfId { get; set; }
        public Shelf TargetShelf { get; set; }
    }
}
