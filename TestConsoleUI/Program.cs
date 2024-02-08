using Bussines.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


namespace TestConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //  BrandTest();
            // ColorAddTest();
            // CarTest();

        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.Add(new Color { Name = "Brown" });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Name + " " + brand.Name);
                }
            }
        }

        private static void CarTest()
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
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}