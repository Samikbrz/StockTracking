using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Drawer : IEntity
    {
        public int DrawerId { get; set; }
        public int DrawerName { get; set; }
        public int ShelfName { get; set; }
    }
}
