using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shelf : IEntity
    {
        public int Id { get; set; }
        public string ShelfName { get; set; }
        public int StoreId { get; set; }
    }
}
