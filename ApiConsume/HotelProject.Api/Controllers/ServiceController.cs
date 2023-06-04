using HotelProject.Business.Abstract;
using HotelProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInser(service);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
