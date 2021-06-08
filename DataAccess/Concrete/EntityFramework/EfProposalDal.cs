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
    public class EfProposalDal : EfEntityRepositoryBase<Proposal, StockTrackingContext>, IProposalDal
    {
        public List<ProposalDto> GetProposalDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from proposal in context.Proposals
                             join user in context.Users                            
                             on proposal.UserId equals user.Id
                             join company in context.Companies
                             on proposal.CompanyId equals company.Id                            
                             select new ProposalDto
                             {
                                Id = proposal.Id,
                                Date=proposal.Date,
                                ProposalNo=proposal.ProposalNo,
                                UserName=user.FirstName+" "+user.LastName,   
                                CompanyName=company.CompanyName,
                                Barcode=proposal.Barcode,
                                Count=proposal.Count,
                                ProposalPrice=proposal.ProposalPrice
                             };
                return result.ToList();
            }
        }
    }
}
