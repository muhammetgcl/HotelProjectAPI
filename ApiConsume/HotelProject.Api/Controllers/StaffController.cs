﻿using HotelProject.Business.Abstract;
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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var staffList = _staffService.TGetList();
            return Ok(staffList);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInser(staff);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
