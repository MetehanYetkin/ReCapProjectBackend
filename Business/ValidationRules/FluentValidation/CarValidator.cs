using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            //RuleFor(p => p.Description).NotEmpty();
        }
        private bool StartWithA(string arg)//arg parametre
        {
            return arg.StartsWith("A");

        }
    }
}
