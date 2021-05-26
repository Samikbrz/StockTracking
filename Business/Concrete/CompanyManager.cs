using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.ProductUnitAdded);
        }

        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(Messages.CompanyDeleted);
        }

        public IDataResult<List<Company>> GetAll()
        {
            _companyDal.GetAll();
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.CompanyLsited);
        }

        public IDataResult<List<Company>> GetByCompanyName(string companyName)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(p => p.CompanyName==companyName));
        }

        public IResult Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
