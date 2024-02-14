using Core.Entities;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Date { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual Car Car { get; set; }

    }
}




// Bir arabanın birden fazla resmi olabilir.
//Api üzerinden arabaya resim ekleyecek sistemi yazınız.
//Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
//Resim silme, güncelleme yetenekleri ekleyiniz.
//Bir arabanın en fazla 5 resmi olabilir.
//Resmin eklendiği tarih sistem tarafından atanacaktır.
//Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
//Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)
//Github linkinizi paylaşınız.

