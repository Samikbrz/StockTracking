using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Model : IEntity
    {
        public int Id { get; set; }       
        public string ModelName { get; set; }
        public string ModelDefination { get; set; }
        public string OriginalBarcode { get; set; }
        public int StockId { get; set; }
    }
}
