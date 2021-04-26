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
    public class ShelfManager : IShelfService
    {
        private IShelfDal _shelfDal;
        public ShelfManager(IShelfDal shelfDal)
        {
            _shelfDal = shelfDal;
        }
        public IResult Add(Shelf shelf)
        {
            _shelfDal.Add(shelf);
            return new SuccessResult(Messages.AddedShelf);
        }

        public IResult Delete(Shelf shelf)
        {
            _shelfDal.Delete(shelf);
            return new SuccessResult(Messages.DeletedShelf);
        }

        public IDataResult<List<Shelf>> GetAll()
        {
            return new SuccessDataResult<List<Shelf>>(_shelfDal.GetAll(), Messages.ListedShelves);
        }

        public IResult Update(Shelf shelf)
        {
            _shelfDal.Update(shelf);
            return new SuccessResult(Messages.UpdatedShelf);
        }
    }
}
