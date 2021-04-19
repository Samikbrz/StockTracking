using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StockKind : IEntity
    {
        public int Id { get; set; }
        public string StockKindName { get; set; }
        public bool IsDefineUnder { get; set; }
        public int UpStockKind { get; set; }
    }
}
