using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity 
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }

        public int BrandOfStockId { get; set; }
        public Stock Stock { get; set; }
    }
}
