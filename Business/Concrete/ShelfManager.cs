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
    public class ShelfManager : IShelfService
    {
        private IShelfDal _shelfDal;
        public ShelfManager(IShelfDal shelfDal)
        {
            _shelfDal = shelfDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Shelf shelf)
        {
            _shelfDal.Add(shelf);
            return new SuccessResult(Messages.AddedShelf);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Shelf shelf)
        {
            var result = _shelfDal.GetAll(s => s.ShelfName == shelf.ShelfName);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.ShelfAlreadyExist);
            }
            _shelfDal.Delete(shelf);
            return new SuccessResult(Messages.DeletedShelf);
        }

        public IDataResult<List<Shelf>> GetAll()
        {
            return new SuccessDataResult<List<Shelf>>(_shelfDal.GetAll(), Messages.ListedShelves);
        }

        public IDataResult<List<Shelf>> GetById(int id)
        {
            return new SuccessDataResult<List<Shelf>>(_shelfDal.GetAll(s=>s.Id==id), Messages.ListedShelves);
        }

        public IDataResult<List<ShelfDto>> GetDetail()
        {
            return new SuccessDataResult<List<ShelfDto>>(_shelfDal.GetShelfDetails());
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(Shelf shelf)
        {
            _shelfDal.Update(shelf);
            return new SuccessResult(Messages.UpdatedShelf);
        }
    }
}
