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
    public class SendMessageManager : GenericManager<SendMessage>, ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal) : base(sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public int TGetSendMessagesCount()
        {
            return _sendMessageDal.GetSendMessagesCount();
        }
    }
}
