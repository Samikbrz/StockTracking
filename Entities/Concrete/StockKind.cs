using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockKind : IEntity
    {
        public int StockKindId { get; set; }
        public int Name{ get; set; }
        public bool IsDefineUnder { get; set; }
        public int UpStockKind { get; set; }
    }
}
