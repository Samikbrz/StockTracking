﻿using Core.DataAccess;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class IMProducUnitDal : ImEntityRepositoryBase<ProductUnit, InMemoryContext> , IProductUnitDal
    { 
        
    }
}
