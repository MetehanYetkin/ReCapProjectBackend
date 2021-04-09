using Core.Utilities.Results;
using Entitiy.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IResult Add(CarImage carImage,IFormFile formFile);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImageByCarId(int id);
        IDataResult<CarImage> Get(int id);

    }
}
