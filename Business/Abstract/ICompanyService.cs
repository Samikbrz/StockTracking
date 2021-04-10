using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<List<Company>> GetAll();
        IResult Add(Company company);
        IResult Update(Company company);
        IResult Delete(Company company);
    }
}
