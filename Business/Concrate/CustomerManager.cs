using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal ıcustomerDal)
        {
            _customerDal = ıcustomerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddingSuccessful);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.DeletingSuccessful);
        }

        public IDataResult<List<Customer>> GetAll()
        {

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetCustomerByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.UpdatingSuccessful);
        }
    }
}
