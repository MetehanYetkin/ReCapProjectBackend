
using Core.Entities.Concrate;
using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            

            
        }
    }
}
