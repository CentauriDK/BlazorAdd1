using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ValidationApi.Controllers
{
    [Route("api/validation")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [HttpGet("name")]
        public IActionResult ValidateName([FromQuery] string name)
        {
            // Simple validation example - accept only names with more than 2 characters
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 2)
            {                
                return BadRequest("Name must be at least 3 characters long.");
            }           

            return  Ok("Name is valid.");
        }

        [HttpGet("phone")]
        public IActionResult ValidatePhoneNumber([FromQuery] string phoneNumber)
        {
            // Simple validation example - accept only numeric phone numbers with 8 digits
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length <=8)
            {
                return BadRequest("Phone number is invalid. Please enter a 8-digit numeric phone number.");
            }

            return Ok("Phone number is valid.");
        }
    }
}
