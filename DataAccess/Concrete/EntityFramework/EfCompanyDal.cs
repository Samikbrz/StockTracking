using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, StockTrackingContext> , ICompanyDal
    {
        public List<CompanyDetailDto> GetCompanyDetails()
        {
            using (StockTrackingContext context=new StockTrackingContext())
            {
                var result = from c in context.Company
                             join p in context.Proposal
                             on c.ProposalId equals p.Id
                             select new CompanyDetailDto
                             {
                                 CompanyId=c.Id,
                                 CompanyName=c.CompanyName,
                                 Date=p.Date,
                                 ProposalNo=p.ProposalNo,
                                 UserName=p.UserName
                             };
                return result.ToList();
            }
        }
    }
}
