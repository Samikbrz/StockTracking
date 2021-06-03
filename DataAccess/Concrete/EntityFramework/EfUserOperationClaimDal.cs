using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, StockTrackingContext>, IUserOperationClaimDal
    {
        public List<UserOperationClaimDto> GetUserOperaitonClaimDetails()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from useroperationclaim in context.UserOperationClaims
                             join user in context.Users
                             on useroperationclaim.UserId equals user.Id
                             join operationclaim in context.OperationClaims
                             on useroperationclaim.OperationClaimId equals operationclaim.Id
                             select new UserOperationClaimDto
                             {
                                 Id = useroperationclaim.Id,                                 
                                 UserName = user.FirstName + " " + user.LastName,
                                 OperationClaimName = operationclaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
