﻿using Core.DataAccess.EntityFramework;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductUnitDal : EfEntityRepositoryBase<ProductUnit, StockTrackingContext> , IProductUnitDal
    {

    }
}
