using Business.Concrate;

using DataAccess.Concrate.EntitiyFramework;
using DataAccess.Concrate.InMemory;
using Entitiy.Concrate;
using System;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            // CarTest();
            //BrandTest();
            //AddingTest();//Customer
            //GetUserDetailsTest();
            //UserAddTest();
           //RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now });
            Console.WriteLine(result.Message);
        }

       

        private static void GetUserDetailsTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetUserDetails().Data)
            {
                Console.WriteLine(user.CompanyName + " / " + user.UserFirstName + " / " + user.UserLastName + " / " + user.Email);
            }
        }

        private static void AddingTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CompanyName = "Kayra Otomotiv", CustomerFirsName = "Kayra", CustomerLastName = "Şeker", UserId = 3 });
            Console.WriteLine(result.Message);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetBrandById(2).Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
                Console.WriteLine(result.Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }
}
