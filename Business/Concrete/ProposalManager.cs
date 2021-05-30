using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

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

        public IDataResult<List<Proposal>> GetById(int id)
        {
            return new SuccessDataResult<List<Proposal>>(_proposalDal.GetAll(p=>p.Id==id), Messages.ListedProposal);
        }

        public IDataResult<List<ProposalDto>> GetDetail()
        {
            return new SuccessDataResult<List<ProposalDto>>(_proposalDal.GetProposalDetails(), Messages.ListedProposal);
        }

        public IResult Update(Proposal proposal)
        {
            _proposalDal.Update(proposal);
            return new SuccessResult(Messages.UpdatedProposal);
        }
    }
}
