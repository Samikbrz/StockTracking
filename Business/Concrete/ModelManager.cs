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
    class ModelManager : IModelService
    {
        private IModelDal _modelDal;
        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public IResult Add(Model model)
        {
           _modelDal.Add(model);
           return new SuccessResult(Messages.AddedModel);
        }

        public IResult Delete(Model model)
        {
           _modelDal.Delete(model);
           return new SuccessResult(Messages.DeletedModel);
        }

        public IDataResult<List<Model>> GetAll()
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(), Messages.ListedModel);
        }

        public IDataResult<List<Model>> GetById(int id)
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(m=>m.Id==id), Messages.ListedModel);
        }

        public IDataResult<List<ModelDto>> GetModelDetail()
        {
            return new SuccessDataResult<List<ModelDto>>(_modelDal.GetModelDetails(), Messages.ListedModel);
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.UpdatedModel);
        }
    }
}
