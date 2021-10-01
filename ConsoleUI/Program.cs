using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            // ColorTest();
            CarDetailsDtoTest();

        }

        private static void CarDetailsDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.BrandName + " " + c.CarName + " " + c.ColorName + " " + c.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            Console.WriteLine("Araba Renkleri");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var c in colorManager.GetAll())
            {
                Console.WriteLine(c.ColorId + " " + c.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandId + " " + c.Description);
            }

        }
    }
}
