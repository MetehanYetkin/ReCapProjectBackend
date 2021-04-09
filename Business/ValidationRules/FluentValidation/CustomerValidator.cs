using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerFirsName).NotEmpty();
            RuleFor(p => p.CustomerFirsName).MinimumLength(2);
            RuleFor(p => p.CompanyName).NotEmpty();
            RuleFor(p => p.CompanyName).MinimumLength(2);
            RuleFor(p => p.CustomerLastName).NotEmpty();
            RuleFor(p => p.CustomerLastName).MinimumLength(2);


        }
    }
}
