using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Store : IEntity
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public bool IsSalesStore { get; set; }
        public int StockStoreId { get; set; }
        public int StoreTranferId { get; set; }
    }
}
