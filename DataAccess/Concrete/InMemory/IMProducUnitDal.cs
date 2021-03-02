using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class IMProducUnitDal : IProductUnitDal
    {
        List<ProductUnit> _productUnits;
        public IMProducUnitDal()
        {
            _productUnits = new List<ProductUnit>
            {
                new ProductUnit{ProductUnitId=1, ProductUnitName="Şişe" },
                new ProductUnit{ProductUnitId=1, ProductUnitName="Kutu" },
                new ProductUnit{ProductUnitId=1, ProductUnitName="Kova"}
            };
        }
        public void Add(ProductUnit entity)
        {
            _productUnits.Add(entity);
        }

        public void Delete(ProductUnit entity)
        {
            ProductUnit productUnitToDelete = _productUnits.SingleOrDefault(p => p.ProductUnitId == entity.ProductUnitId);
            _productUnits.Remove(productUnitToDelete);
        }

        public ProductUnit Get(Expression<Func<ProductUnit, bool>> filter)
        {
            return _productUnits.SingleOrDefault(p => p.ProductUnitName.Contains(filter.ToString()));
        }

        public List<ProductUnit> GetAll(Expression<Func<ProductUnit, bool>> filter = null)
        {
            return _productUnits;
        }

        public void Update(ProductUnit entity)
        {
            ProductUnit productUnitToUpdate = _productUnits.SingleOrDefault(p => p.ProductUnitId == entity.ProductUnitId);
            productUnitToUpdate.ProductUnitId = entity.ProductUnitId;
            productUnitToUpdate.ProductUnitName = entity.ProductUnitName;
        }
    }
}
