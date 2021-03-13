using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(5);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(50).When(c => c.BrandId == 1);
            RuleFor(c => c.ModelYear).Must(onlyNewModels).When(c => c.BrandId == 2).WithMessage(Messages.ProductInvalid);
        }

        private bool onlyNewModels(int arg)
        {
            return arg > 2010;
        }
    }
}
