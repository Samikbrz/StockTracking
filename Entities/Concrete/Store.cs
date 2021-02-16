using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Store : IEntity
    {
        public int StoreId { get; set; }
        public int StoreName { get; set; }
        public bool IsSalesStore { get; set; }
    }
}
