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

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "  " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
           

        }

        private static void BrandTest()
        {
            Brand brand1 = new Brand();
            brand1.BrandName = "Mercedes";

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand1);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
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



            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
