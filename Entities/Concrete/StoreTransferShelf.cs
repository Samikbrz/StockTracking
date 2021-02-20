using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransferShelf
    {
        public int StockStoreId { get; set; }
        public StockStore StockStore { get; set; }

        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
    }
}
