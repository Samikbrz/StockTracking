using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProposalService
    {
        IDataResult<List<Proposal>> GetAll();
        IDataResult<List<ProposalDto>> GetDetail();
        IResult Add(Proposal proposal);
        IResult Delete(Proposal proposal);
        IResult Update(Proposal proposal);
    }
}
