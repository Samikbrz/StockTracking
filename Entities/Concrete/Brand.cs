﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity 
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }                
    }
}
