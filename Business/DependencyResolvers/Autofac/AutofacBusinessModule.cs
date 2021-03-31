﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<EfProductUnitDal>().As<IProductUnitDal>().SingleInstance();
           builder.RegisterType<ProductUnitManager>().As<IProductUnitService>().SingleInstance();
        }
    }
}
