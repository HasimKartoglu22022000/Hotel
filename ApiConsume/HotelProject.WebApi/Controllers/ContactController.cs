using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactServices _contactServices;

        public ContactController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
            _contactServices.TInsert(contact);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactServices.TGetByID(id);
            return Ok(values);
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactServices.TGetList();
            return Ok(values);
        }
    }
}
