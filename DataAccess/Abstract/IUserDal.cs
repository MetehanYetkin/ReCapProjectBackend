using Core.DataAccess;
using Core.Entities.Concrate;

using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserDal:IEntityRepository<User>
    {
        List<UserDetailDto> GetUserDetails();
        List<OperationClaim> GetClaims(User user);
        List<UserDetailDto> GetUserDetailsByMail(string mail);
    }
}
