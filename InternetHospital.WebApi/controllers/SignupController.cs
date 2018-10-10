using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using InternetHospital.BusinessLogic.Models;

namespace InternetHospital.WebApi.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        // GET: api/Signup/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Signup
        [HttpPost]
        public ActionResult Register([FromBody] UserRegistrationModel vm)
        {
            // we also need to add automapper for mapping vm to user DB entity
            // example of logic
            if (vm.Role == "Doctor")
            {

            }
            else if (vm.Role == "Patient")
            {

            }
            else
            {
                return BadRequest("Invalid request");
            }

            // again use automapper to map our user DB entity to vm
            return Ok(vm);
        }


    }
}
