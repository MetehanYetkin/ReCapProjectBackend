using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
   public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.RentDate).NotEmpty();
        }
    }
}
