using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal ıuserDal)
        {
            _userDal = ıuserDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            _userDal.Add(user);
          
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.DeletingSuccessful);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public User GetByMail(string mail)
        {
          
          return  _userDal.Get(u => u.Email == mail);
            
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails());
        }

        public IDataResult<List<UserDetailDto>> GetUserDetailsByMail(string mail)
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetailsByMail(mail));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UpdatingSuccessful);
        }
    }
}
