using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shelf : IEntity
    {
        public int ShelfId { get; set; }
        public string ShelfName { get; set; }
        public string StoreName { get; set; }
    }
}
