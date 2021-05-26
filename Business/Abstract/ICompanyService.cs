using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<List<Company>> GetAll();       
        IDataResult<List<Company>> GetCompanyById(int id);
        IResult Add(Company company);
        IResult Update(Company company);
        IResult Delete(Company company);
    }
}
