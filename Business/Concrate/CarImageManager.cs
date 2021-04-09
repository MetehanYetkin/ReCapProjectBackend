using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _ıcarImageDal;
        public CarImageManager(ICarImageDal ıcarImageDal)
        {
            _ıcarImageDal = ıcarImageDal;
        }

      [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(CarImage carImage, IFormFile formFile)
        {
          IResult result=  BusinessRules.Run(CheckIfImageLimit(carImage.CarId),DefaultImage(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            carImage.ImagePath =FileHelper.FileAdd(formFile);// formFile.ToString();
                
            carImage.ImageDate = DateTime.Now;
            _ıcarImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            FileHelper.FileDelete(carImage.ImagePath);
            _ıcarImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_ıcarImageDal.Get(p=>p.ImageId==id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_ıcarImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetImageByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_ıcarImageDal.GetAll(p=>p.ImageId==id));
        }

        public IResult Update( IFormFile formFile, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.FileUpdate(_ıcarImageDal.Get(p=>p.ImageId==carImage.ImageId).ImagePath,formFile);
            carImage.ImageDate = DateTime.Now;
            _ıcarImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckIfImageLimit(int id)
        {
            var result = _ıcarImageDal.GetAll(p => p.CarId == id).Count;
            if (result <=5)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ImagesLimitExcated);
        }
        private IDataResult<List<CarImage>> DefaultImage(int id)
        {
            
            try
            {string path = @"\wwwroot\Images\default.jpg";
            var result = _ıcarImageDal.GetAll(p => p.ImageId == id).Any();
            if (!result)
            {
                List<CarImage> carImages = new List<CarImage>();
                carImages.Add(new CarImage { CarId = id, ImageDate = DateTime.Now, ImagePath = path });
                return new SuccessDataResult<List<CarImage>>(carImages);
            }
            
            }
            catch (Exception )
            {

                return new ErrorDataResult<List<CarImage>>(Messages.NotImage);
            }

            return new SuccessDataResult<List<CarImage>>(_ıcarImageDal.GetAll(p => p.CarId == id).ToList());
        }
    }
}
