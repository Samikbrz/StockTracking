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
    public class DrawerManager : IDrawerService
    {
        private IDrawerDal _drawerDal;
        private IStockStoreDal _stockStoreDal;
        public DrawerManager(IDrawerDal drawerDal,IStockStoreDal stockStoreDal)
        {
            _drawerDal = drawerDal;
            _stockStoreDal = stockStoreDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Drawer drawer)
        {
            var result = _drawerDal.GetAll(d => d.DrawerName == drawer.DrawerName);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.DrawerAlreadyExist);
            }
            _drawerDal.Add(drawer);
            return new SuccessResult(Messages.DrawerAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Drawer drawer)
        {
            var result = _stockStoreDal.GetAll(d => d.DrawerId == drawer.Id);
            if (result.Count!=0)
            {
                return new ErrorResult(Messages.DrawerDoesNotDeleted);
            }
            _drawerDal.Delete(drawer);
            return new SuccessResult(Messages.DeletedDrawer);
        }

        public IDataResult<List<Drawer>> GetAll()
        {
            return new SuccessDataResult<List<Drawer>>(_drawerDal.GetAll(), Messages.DrawerListed);
        }

        public IDataResult<List<Drawer>> GetById(int id)
        {
            return new SuccessDataResult<List<Drawer>>(_drawerDal.GetAll(d=>d.Id==id), Messages.DrawerListed);
        }

        public IDataResult<List<DrawerDto>> GetDetail()
        {
            return new SuccessDataResult<List<DrawerDto>>(_drawerDal.GetDrawerDetails(), Messages.DrawerListed);
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(Drawer drawer)
        {
            _drawerDal.Update(drawer);
            return new SuccessResult(Messages.DrawerUpdated);
        }
    }
}
