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
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal) : base(appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> TGetUserListWithWorkLocations()
        {
            return _appUserDal.GetUserListWithWorkLocations();
        }
    }
}
