﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Stock : IEntity
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public int Piece { get; set; }
        public decimal CriticalLevel { get; set; }
        public decimal UnitPrice { get; set; }
        public string Catalog { get; set; }
    }
}
