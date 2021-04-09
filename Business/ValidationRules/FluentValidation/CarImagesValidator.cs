using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarImagesValidator:AbstractValidator<CarImage>
    {
        public CarImagesValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CarId).GreaterThan(0);
        }

    }
}
