using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DrawerDto : IDto
    {
        public int Id { get; set; }
        public string DrawerName { get; set; }        
        public string ShelfName { get; set; }        
    }
}
