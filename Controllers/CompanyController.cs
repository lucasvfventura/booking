﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booking.Data.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private ICompanyRepository repository;

        public CompanyController(ICompanyRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] string expression)
        {
            var companies = await repository.GetAllAsync();
            return Json(companies);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
