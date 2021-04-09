using Core.Utilities.Results;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
       IDataResult< List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id);
       IDataResult< List<CarDetailDto>> GetCarDetailsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByImageId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndBrandId(int colorid, int brandid);
        IDataResult<List<Car>> GetCarsByColorId(int id);
       IDataResult< List<CarDetailDto>>GetCarDetailsById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
       IResult Update(Car car);
        IResult AddTransactionalTest(Car car);
    }
}
