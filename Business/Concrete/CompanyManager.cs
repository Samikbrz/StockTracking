using Business.Abstract;
using Business.BusinessAspect.Autofac;
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
        [SecuredOperation("admin")]
        public IResult Add(Company company)
        {
            var result = _companyDal.GetAll(c => c.CompanyName == company.CompanyName);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.CompanyAlreadyExist);
            }
            _companyDal.Add(company);
            return new SuccessResult(Messages.ProductUnitAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(Messages.DeletedCompany);
        }

        public IDataResult<List<Company>> GetAll()
        {
            _companyDal.GetAll();
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.ListedCompany);
        }

        public IDataResult<List<Company>> GetCompanyById(int id)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(p => p.Id==id));
        }

        [SecuredOperation("admin,empolyee")]
        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(Messages.UpdatedCompany);
        }
    }
}
