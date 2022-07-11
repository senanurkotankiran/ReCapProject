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
            CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car();
            //car1.BrandId = 1;
            //car1.CarName = "Fiat Doblo";
            //car1.ColorId = 1;
            //car1.DailyPrice = 475;
            //car1.Description = "Manuel Vites";
            //car1.ModelYear = 2016;

            //carManager.Add(car1);



            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarName);
            }

           

        }
    }
}
