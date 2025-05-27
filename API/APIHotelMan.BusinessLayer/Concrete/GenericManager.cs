using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void TDelete(T t)
        {
            _genericDal.Delete(t);
        }

        public T TGetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public List<T> TGetList()
        {
            return _genericDal.GetList();
        }

        public void TInsert(T t)
        {
            _genericDal.Insert(t);
        }

        public void TUpdate(T t)
        {
            _genericDal.Update(t);
        }
    }
}
