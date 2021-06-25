using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Microsoft.AspNetCore.Http;
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

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<DrawerManager>().As<IDrawerService>().SingleInstance();
            builder.RegisterType<EfDrawerDal>().As<IDrawerDal>().SingleInstance();            

            builder.RegisterType<ModelManager>().As<IModelService>().SingleInstance();
            builder.RegisterType<EfModelDal>().As<IModelDal>().SingleInstance();

            builder.RegisterType<ProductAcceptanceManager>().As<IProductAcceptanceService>().SingleInstance();
            builder.RegisterType<EfProductAcceptanceDal>().As<IProductAcceptanceDal>().SingleInstance();

            builder.RegisterType<ProductOutputManager>().As<IProductOutputService>().SingleInstance();
            builder.RegisterType<EfProductOutputDal>().As<IProductOutputDal>().SingleInstance();

            builder.RegisterType<ProposalManager>().As<IProposalService>().SingleInstance();
            builder.RegisterType<EfProposalDal>().As<IProposalDal>().SingleInstance();

            builder.RegisterType<StockKindManager>().As<IStockKindService>().SingleInstance();
            builder.RegisterType<EfStockKindDal>().As<IStockKindDal>().SingleInstance();

            builder.RegisterType<StockStoreManager>().As<IStockStoreService>().SingleInstance();
            builder.RegisterType<EfStockStoreDal>().As<IStockStoreDal>().SingleInstance();

            builder.RegisterType<StoreManager>().As<IStoreService>().SingleInstance();
            builder.RegisterType<EfStoreDal>().As<IStoreDal>().SingleInstance();

            builder.RegisterType<StoreTransferManager>().As<IStoreTransferService>().SingleInstance();
            builder.RegisterType<EfStoreTransferDal>().As<IStoreTransferDal>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<ShelfManager>().As<IShelfService>().SingleInstance();
            builder.RegisterType<EfShelfDal>().As<IShelfDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();            

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
