using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal ırentalDal)
        {
            _rentalDal = ırentalDal;
        }
        [SecuredOperation("admin,cars.add")]
         [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            
           
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.AddingSuccessful);
           
          
               
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletingSuccessful);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetRentalByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CustomerId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatingSuccessful);
        }
    }
}
