using Entities.Concrete;

namespace DataAccess.Absract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
/*
 * Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.

Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

Bir araba nesnesi oluşturunuz. "Car"


InMemory formatta GetById, , Add, Update, Delete oprasyonlarını yazınız.
*/