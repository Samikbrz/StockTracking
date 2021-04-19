using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Drawer : IEntity
    {
        public int Id { get; set; }
        public string DrawerName { get; set; }
        public int ShelfId { get; set; }      
    }
}
