﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductUnit : IEntity
    {
        public int Id { get; set; }
        public string ProductUnitName { get; set; }
    }
}
