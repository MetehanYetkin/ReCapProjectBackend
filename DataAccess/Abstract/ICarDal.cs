using Core.DataAccess;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICarDal:IEntityRepository<Car>

    {
        List<CarDetailDto> GetCarDetails();
       List<CarDetailDto> GetCarDetailsByBrandId(int id);
        List<CarDetailDto> GetCarDetailsByColorId(int id);
        List<CarDetailDto> GetCarDetailsByImageId(int id);
        List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid, int brandid);
        List<CarDetailDto> GetCarDetailsById(int id);


    }
}
