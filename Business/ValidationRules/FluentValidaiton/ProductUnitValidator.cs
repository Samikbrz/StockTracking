using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaiton
{
    public class ProductUnitValidator : AbstractValidator<ProductUnit>
    {
        public ProductUnitValidator()
        {
            RuleFor(p => p.ProductUnitName).MinimumLength(2);
            RuleFor(p => p.ProductUnitName).NotEmpty();           
        }
    }
}
