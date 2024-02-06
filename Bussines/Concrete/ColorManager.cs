using Bussines.Absract;
using DataAccess.Absract;
using Entities.Concrete;


namespace Bussines.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
