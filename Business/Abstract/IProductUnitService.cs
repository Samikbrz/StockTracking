using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductUnitService
    {
        List<ProductUnit> GetAll();
        void Add(ProductUnit productUnit);
        void Update(ProductUnit productUnit);
        void Delete(ProductUnit productUnit);
    }
}
