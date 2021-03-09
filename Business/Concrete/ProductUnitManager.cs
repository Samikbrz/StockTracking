using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductUnitManager : IProductUnitService
    {
        IProductUnitDal _productUnitDal;
        public ProductUnitManager(IProductUnitDal productUnitDal)
        {
            productUnitDal = _productUnitDal;
        }
        public void Add(ProductUnit productUnit)
        {
            _productUnitDal.Add(productUnit);
        }

        public void Delete(ProductUnit productUnit)
        {
            _productUnitDal.Delete(productUnit);
        }

        public List<ProductUnit> GetAll()
        {
            return _productUnitDal.GetAll();
        }

        public void Update(ProductUnit productUnit)
        {
            _productUnitDal.Update(productUnit);
        }
    }
}
