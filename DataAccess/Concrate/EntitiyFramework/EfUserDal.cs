using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Core.Entities.Concrate;

namespace DataAccess.Concrate.EntitiyFramework
{
  public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectSQLDemoContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
             var result=from operationClaim in context.OperationClaims
                join userOperationClaim in context.UserOperationClaims
                    on operationClaim.ClaimId equals userOperationClaim.OperationClaimId
                where userOperationClaim.UserId == user.UserId
                select new OperationClaim { ClaimId = operationClaim.ClaimId, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public List<UserDetailDto> GetUserDetails( )
        {
            using (ReCapProjectSQLDemoContext context =new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Userss 
                             join c in context.Customers
                             on p.UserId equals c.UserId
                           
                             select new UserDetailDto { CompanyName = c.CompanyName, Email = p.Email, UserFirstName = p.FirstName, UserLastName = p.LastName };
                return result.ToList();
                            
                             
            }
        }
        public List<UserDetailDto> GetUserDetailsByMail(string mail)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Userss
                             join c in context.Customers
                             on p.UserId equals c.UserId
                             where p.Email==mail

                             select new UserDetailDto { CompanyName = c.CompanyName, Email = p.Email, UserFirstName = p.FirstName, UserLastName = p.LastName };
                return result.ToList();


            }
        }

    }
}
