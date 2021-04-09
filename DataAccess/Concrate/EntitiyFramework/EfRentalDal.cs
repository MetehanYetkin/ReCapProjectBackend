using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EntitiyFramework
{
  public class EfRentalDal: EfEntityRepositoryBase<Rental, ReCapProjectSQLDemoContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectSQLDemoContext context = new ReCapProjectSQLDemoContext())
            {
                var result = from r in context.Rentalss
                             join c in context.Customers on r.CustomerId equals c.CustomerId
                             join b in context.Cars on r.CarId equals b.CarId
                             select new RentalDetailDto
                             {
                                 CarName = b.CarName, CustomerFirsName = c.CustomerFirsName, CustomerLastName = c.CustomerLastName,
                                 RentDate = r.RentDate, ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
