using Bussines.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace TestConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine($"Id:{car.Id} \nBrandId:  {car.BrandId} \nColorId:  {car.ColorId}  \nModelYear: {car.ModelYear} \nDailyPrice: {car.DailyPrice}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}