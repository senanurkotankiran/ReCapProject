using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();
            // SuccessTest();
            //RentalTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.RentDate );
            }
        }

        private static void RentalTest()
        {
            Rental rental1 = new Rental();
            rental1.CarId = 1;
            rental1.CustomerId = 1;
            rental1.RentDate = new DateTime(2022, 7, 21);
            rental1.RentDate = new DateTime(2022, 7, 28);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(rental1);
        }

        private static void SuccessTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            if (carManager.GetCarDetails().Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "  " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
                }

            }
            else
            {
                Console.WriteLine(carManager.GetCarDetails().Message);
            }
        }

        private static void BrandTest()
        {
            Brand brand1 = new Brand();
            brand1.BrandName = "Mercedes";

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand1);
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car();
            car1.BrandId = 1;
            car1.CarName = "Fiat Doblo";
            car1.ColorId = 1;
            car1.DailyPrice = 475;
            car1.Description = "Manuel Vites";
            car1.ModelYear = 2016;

            carManager.Add(car1);



            //foreach (var car in carManager.GetAll())
            //{
             //   Console.WriteLine(car.CarName);
            //}
        }
    }
}
