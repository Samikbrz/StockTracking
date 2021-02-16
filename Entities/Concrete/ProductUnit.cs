using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductUnit : IEntity
    {
        public int ProductUnitId { get; set; }
        public string ProductUnitName { get; set; }
    }
}
