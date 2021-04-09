using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car> {
                new Car{ BrandId=1,CarId=1,ColorId=1,DailyPrice=500,Description="Wolswagen model kırmızı araba",ModelYear=2021 },
                new Car{ BrandId=2,CarId=1,ColorId=2,DailyPrice=1500,Description="Opel model siyah araba",ModelYear=2021 },
                new Car{ BrandId=3,CarId=1,ColorId=3,DailyPrice=400,Description="volvo model beyaz araba",ModelYear=2020 },
                new Car{ BrandId=1,CarId=2,ColorId=4,DailyPrice=900,Description="Wolswagen model mor araba",ModelYear=2019 },
                new Car{ BrandId=1,CarId=3,ColorId=1,DailyPrice=200,Description="Wolswagen model kırmızı araba",ModelYear=2020 },
            
            
            
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carsToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid, int brandid)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByImageId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
