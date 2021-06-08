using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
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
        private IStockStoreDal _stockStoreDal;
        public ProposalManager(IProposalDal proposalDal,IStockStoreDal stockStoreDal)
        {
            _proposalDal = proposalDal;
            _stockStoreDal= stockStoreDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Proposal proposal)
        {
            var result = _stockStoreDal.GetAll(p => p.Barcode != proposal.Barcode);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.BarcodeNotFound);
            }
            _proposalDal.Add(proposal);
            return new SuccessResult(Messages.AddedProposal);
        }

        [SecuredOperation("admin")]
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

        [SecuredOperation("admin")]
        public IResult Update(Proposal proposal)
        {
            _proposalDal.Update(proposal);
            return new SuccessResult(Messages.UpdatedProposal);
        }
    }
}
