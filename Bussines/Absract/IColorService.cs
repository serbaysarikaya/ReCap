using Entities.Concrete;

namespace Bussines.Absract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
