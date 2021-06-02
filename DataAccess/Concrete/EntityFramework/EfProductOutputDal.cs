using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductOutputDal : EfEntityRepositoryBase<ProductOutput, StockTrackingContext>, IProductOutputDal
    {
        public List<ProductOutputDto> GetProductOutputDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from productoutput in context.ProductOutputs
                             join company in context.Companies
                             on productoutput.CompanyId equals company.Id
                             join user in context.Users
                             on productoutput.UserId equals user.Id
                             select new ProductOutputDto
                             {
                                 Id = productoutput.Id,
                                 Date=productoutput.Date,
                                 ExitNumber=productoutput.ExitNumber,
                                 TotalPrice=productoutput.TotalPrice,
                                 UserName=user.FirstName+""+user.LastName,
                                 CompanyName = company.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
