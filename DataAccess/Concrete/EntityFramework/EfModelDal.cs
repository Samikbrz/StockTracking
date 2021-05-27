using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfModelDal : EfEntityRepositoryBase<Model, StockTrackingContext>, IModelDal
    {
        public List<ModelDto> GetModelDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from model in context.Models
                             join brand in context.Brands
                             on model.BrandId equals brand.Id
                             select new ModelDto
                             {
                                Id=model.Id,
                                BrandName=brand.BrandName,
                                ModelDefination=model.ModelDefination,
                                ModelName=model.ModelName,
                                OriginalBarcode=model.OriginalBarcode
                             };
                return result.ToList();
            }                       
        }
    }
}
