using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProposalService
    {
        IDataResult<List<Proposal>> GetAll();
        IResult Add(Proposal proposal);
        IResult Delete(Proposal proposal);
        IResult Update(Proposal proposal);
    }
}
