using Bussines.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace TestConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine($"CarName: {car.CarName} \nColor: {car.ColorName} \nBrand: {car.BrandName} \nPrice: {car.DailyPrice}");
                Console.WriteLine(" <<<<<<<----------->>>>>");
            }

        }
    }
}