using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProposalManager : IProposalService
    {
        private IProposalDal _proposalDal;
        public ProposalManager(IProposalDal proposalDal)
        {
            _proposalDal = proposalDal;
        }
        public IResult Add(Proposal proposal)
        {
            _proposalDal.Add(proposal);
            return new SuccessResult(Messages.AddedProposal);
        }

        public IResult Delete(Proposal proposal)
        {
            _proposalDal.Delete(proposal);
            return new SuccessResult(Messages.DeletedProposal);
        }

        public IDataResult<List<Proposal>> GetAll()
        {
            return new SuccessDataResult<List<Proposal>>(_proposalDal.GetAll(), Messages.ListedProposal);
        }

        public IResult Update(Proposal proposal)
        {
            _proposalDal.Update(proposal);
            return new SuccessResult(Messages.UpdatedProposal);
        }
    }
}
