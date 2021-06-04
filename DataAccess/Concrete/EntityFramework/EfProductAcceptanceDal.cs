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
    public class EfProductAcceptanceDal : EfEntityRepositoryBase<ProductAcceptance, StockTrackingContext>, IProductAcceptanceDal
    {
        public List<ProductAcceptanceDto> GetProductAcceptanceDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from productacceptance in context.ProductAcceptances
                             join user in context.Users
                             on productacceptance.UserId equals user.Id
                             join company in context.Companies
                             on productacceptance.CompanyId equals company.Id
                             select new ProductAcceptanceDto
                             {
                                 Id = productacceptance.Id,
                                 AcceptanceDate = productacceptance.AcceptanceDate,
                                 ProductRegistrationNumber = productacceptance.ProductRegistrationNumber,
                                 UserName = user.FirstName + " " + user.LastName,
                                 CompanyName = company.CompanyName,
                                 ProductName=productacceptance.ProductName,
                                 UnitPrice=productacceptance.UnitPrice,
                                 Count=productacceptance.Count,
                                 TotalPrice=productacceptance.TotalPrice,
                                 Barcode=productacceptance.Barcode
                             };
                return result.ToList();
            }
        }
    }
}
