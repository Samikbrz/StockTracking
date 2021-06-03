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
    public class DrawerManager : IDrawerService
    {
        private IDrawerDal _drawerDal;
        public DrawerManager(IDrawerDal drawerDal)
        {
            _drawerDal = drawerDal;
        }
        public IResult Add(Drawer drawer)
        {
            _drawerDal.Add(drawer);
            return new SuccessResult(Messages.DrawerAdded);
        }

        public IResult Delete(Drawer drawer)
        {
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
            return new SuccessDataResult<List<DrawerDto>>(_drawerDal.GetShelfDetails(), Messages.DrawerListed);
        }

        public IResult Update(Drawer drawer)
        {
            _drawerDal.Update(drawer);
            return new SuccessResult(Messages.DrawerUpdated);
        }
    }
}
