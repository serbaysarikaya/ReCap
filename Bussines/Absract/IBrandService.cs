using Core.Utilities.Results;
using Entities.Concrete;

namespace Bussines.Absract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
/*

 

Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName
*****Kullanıcılar ve müşteriler ilişkilidir.
Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi)ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
Projenizde bu entity'leri oluşturunuz.
CRUD operasyonlarını yazınız.
Yeni müşteriler ekleyiniz.
Arabayı kiralama imkanını kodlayınız. Rental-->Add
Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.
 
 */