using Core.Entities.Concrate;
using Core.Utilities.Results;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        void Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> GetUserDetails();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string mail);
        IDataResult<List<UserDetailDto>> GetUserDetailsByMail(string mail);
    }
}
