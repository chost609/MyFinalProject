using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(item => item.ProductName).MinimumLength(2);
            RuleFor(item => item.ProductName).NotEmpty();
            RuleFor(item => item.UnitPrice).NotEmpty();
            RuleFor(item => item.UnitPrice).GreaterThan(0);
            RuleFor(item => item.UnitPrice).GreaterThanOrEqualTo(10).When(item => item.CategoryId == 1);
            RuleFor(item => item.ProductName).Must(StartWithA).WithMessage("Urunler A Harfi ile baslamalidir");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
