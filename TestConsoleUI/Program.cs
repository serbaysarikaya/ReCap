using Bussines.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace TestConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success)
            {

                foreach (var car in result.Data)
                {

                    Console.WriteLine($"CarName: {car.CarName} \nColor: {car.ColorName} \nBrand: {car.BrandName} \nPrice: {car.DailyPrice}");
                    Console.WriteLine(" <<<<<<<----------->>>>>");
                }
            }

        }
    }
}