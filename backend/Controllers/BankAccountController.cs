using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using backend.Data.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Authorize]
    [EnableCors("AnyGet")]
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private IBankRepository _repository;

        public BankAccountController(IBankRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var account = _repository.CreateAccount();
        }
    }
}
