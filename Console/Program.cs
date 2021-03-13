using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            

            IResult deneme = carManager.Add(new Car { BrandId = 2, ColorId=1, DailyPrice=2, Description="carsamba dersi denemesi", ModelYear=3999}); ;
            System.Console.WriteLine(deneme.Message);
            foreach(var car in carManager.GetCarDetails().Data)
            {
                System.Console.WriteLine("{0} {1} {2} {3}", car.BrandName, car.CarDetails, car.ColorName, car.DailyPrice);
            }
            
     
        }
    }
}
