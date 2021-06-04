using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        private IOperationClaimDal _operationClaimDal;
        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }
        public IResult Add(OperationClaim operationClaim)
        {
            var result = _operationClaimDal.GetAll(o => o.Name == operationClaim.Name);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.OperationClaimAlreadyExist);
            }
            _operationClaimDal.Add(operationClaim);
            return new SuccessResult(Messages.AddedOperationClaim);
        }

        public IResult Delete(OperationClaim operationClaim)
        {
            _operationClaimDal.Delete(operationClaim);
            return new SuccessResult(Messages.DeletedOperationClaim);
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll(), Messages.ListedOperationClaims);
        }

        public IDataResult<List<OperationClaim>> GetById(int id)
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll(o=>o.Id==id));
        }

        public IResult Update(OperationClaim operationClaim)
        {
            _operationClaimDal.Update(operationClaim);
            return new SuccessResult(Messages.UpdatedOperationClaim);
        }
    }
}
