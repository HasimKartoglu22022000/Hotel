using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices)
        {
            _bookingServices = bookingServices;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingServices.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingServices.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingServices.TGetByID(id);
            _bookingServices.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingServices.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingServices.TGetByID(id);
            return Ok(values);
        }

        [HttpPut("UpdateReservation")]
        public IActionResult UpdateReservation(Booking booking)
        {
            _bookingServices.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("UpdateReservation2")]
        public IActionResult UpdateReservation2(int id)
        {
            _bookingServices.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
