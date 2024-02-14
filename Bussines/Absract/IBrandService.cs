﻿using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IBrandService
    {
        IDataResult<List<BrandDto>> GetAll();
        IResult Add(BrandDto brandDto);
        IResult Update(BrandDto brandDto);
        IResult Delete(BrandDto brandDto);
        IDataResult<BrandDto> GetById(int id);

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