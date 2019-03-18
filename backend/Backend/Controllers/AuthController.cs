using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using backend.Data.Models;
using Microsoft.AspNetCore.Mvc;
using backend.Filters;


namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ValidateModel]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public IActionResult CreateToken([FromBody] CredentialModel model)
        {
            // if (!ModelState.IsValid) return BadRequest(ModelState);
            // Rmplaced by [ValidateModel]
            try
            {

            }
            catch (Exception ex)
            {

            }
            return BadRequest("Failed to generate token");
        }



        [HttpPost("login")]
        public IActionResult Login([FromBody]CredentialModel model)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return BadRequest("Faile to login");
        }
    }
}
