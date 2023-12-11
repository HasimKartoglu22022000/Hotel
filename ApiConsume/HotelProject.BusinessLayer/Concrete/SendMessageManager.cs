using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessage;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessage = sendMessageDal;
        }
        public void TDelete(SendMessage t)
        {
            _sendMessage.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMessage.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessage.GetList();
        }

        public void TInsert(SendMessage t)
        {
            _sendMessage.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            _sendMessage.Update(t);
        }
    }
}
