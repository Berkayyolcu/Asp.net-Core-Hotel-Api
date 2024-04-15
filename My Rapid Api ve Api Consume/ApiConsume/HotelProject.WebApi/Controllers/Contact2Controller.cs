using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contact2Controller : ControllerBase
    {
        private readonly IContact2Service _contact2Service;

        public Contact2Controller(IContact2Service contact2Service)
        {
            _contact2Service = contact2Service;
        }

        [HttpGet]
        public IActionResult Contact2List()
        {
            var values = _contact2Service.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact2(Contact2 contact2)
        {
            _contact2Service.TInsert(contact2);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact2(int id)
        {
            var values = _contact2Service.TGetByID(id);
            _contact2Service.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact2(Contact2 contact2)
        {
            _contact2Service.TUpdate(contact2);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContact2(int id)
        {
            var values = _contact2Service.TGetByID(id);
            return Ok(values);
        }
    }
}
