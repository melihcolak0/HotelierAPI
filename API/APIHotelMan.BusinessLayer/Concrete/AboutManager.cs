using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.DataAccessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.BusinessLayer.Concrete
{
    public class AboutManager : GenericManager<About>, IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal) : base(aboutDal)
        {
            _aboutDal = aboutDal;
        }
    }
}
