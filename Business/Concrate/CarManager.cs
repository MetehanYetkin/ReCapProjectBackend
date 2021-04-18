using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
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
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        
        public CarManager(ICarDal ıCarDal)
        {
            
            _carDal = ıCarDal;
        }
        [CacheAspect]
        [SecuredOperation("admin,cars.add")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarsServiceGet")]
        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.AddingNotSuccessful);
            }
           _carDal.Add(car);
            return new SuccessResult(Messages.AddingSuccessful);
        }
        [SecuredOperation("admin,cars.add")]
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice<100)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }
        [PerformanceAspect(5)]
        [SecuredOperation("admin,cars.add")]
        public IResult Delete(Car car)
        {
            
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletingSuccessful);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
           
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByBrandId(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndBrandId(int colorid, int brandid)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByColorAndBrandId(colorid, brandid));
        }

        public IDataResult<List<CarDetailDto>>GetCarDetailsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByColorId(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsById(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsById(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByImageId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByImageId(id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return  new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }
        [SecuredOperation("admin,cars.add")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult( Messages.UpdatingSuccessful);
        }
       
    }
}
