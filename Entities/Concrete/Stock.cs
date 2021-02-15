using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Stock : IEntity
    {
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProductName { get; set; }
        public string Piece { get; set; } // adet
        public string CriticalLevel { get; set; }
        public string UnitPrice { get; set; }
        public string Catalog { get; set; }
    }
}
