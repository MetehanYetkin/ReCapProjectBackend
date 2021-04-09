using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntitiyFramework
{
   public class EfCarDal : EfEntityRepositoryBase<Car,ReCapProjectSQLDemoContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectSQLDemoContext context=new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             select new CarDetailDto { CarName = p.CarName, ColorName = c.ColorName, BrandName = b.BrandName, DailyPrice=p.DailyPrice 
                             ,Description=p.Description ,ModelYear=p.ModelYear , UnitsInStock=p.UnitsInStock,CarId=p.CarId};
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsById(int id)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             where(p.CarId==id)
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             ,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 UnitsInStock = p.UnitsInStock,
                                 CarId = p.CarId
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int id)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             where (b.BrandId == id)
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             ,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 UnitsInStock = p.UnitsInStock,
                                 CarId = p.CarId

                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByColorId(int id)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             where (c.ColorId == id)
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             ,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 UnitsInStock = p.UnitsInStock,
                                 CarId = p.CarId

                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByImageId(int id)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join i in context.CarImagess on p.CarId equals i.CarId
                             where (i.CarId == id)
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             ,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 UnitsInStock = p.UnitsInStock,
                                 ImagePath = i.ImagePath,
                                 CarId=p.CarId
                                 
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid,int brandid)
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join i in context.CarImagess on p.CarId equals i.CarId
                             where (b.BrandId==brandid && c.ColorId == colorid)
                            

                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             ,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 UnitsInStock = p.UnitsInStock,
                                 ImagePath = i.ImagePath,
                                 CarId = p.CarId

                             };
                return result.ToList();
            }
        }
    }
}
