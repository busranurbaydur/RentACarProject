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
            CarTest2();

            //ColorTest();
            //CarDetailsDtoTest();

        }

        private static void CarDetailsDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(c.BrandName + " " + c.CarName + " " + c.ColorName + " " + c.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            Console.WriteLine("Araba Renkleri");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var c in colorManager.GetAllColors().Data)
            {
                Console.WriteLine(c.ColorId + " " + c.ColorName );
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetAll().Data)
            {
                
                Console.WriteLine(c.BrandId + " " + c.Description);
            }

        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { DailyPrice = 225, BrandId = 3, ColorId = 5, Description = " otomatik ", ModelYear = 2022 });
            //carManager.Add(new Car { DailyPrice = 500, BrandId = 6, ColorId = 2, Description = " lüks ", ModelYear = 2019 });


            var result = carManager.GetCarDetails();

            Console.WriteLine(" ---KİRALIK ARAÇ LİSTESİ VE FİYATLARI--- ");
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "  " + car.CarName + "  " + car.ColorName + " Günlük Fiyatı " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
