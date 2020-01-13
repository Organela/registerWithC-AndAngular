using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Register.Domain.Repositories;

namespace Register.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository PersonRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            PersonRepository = personRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PersonRepository.GetAll());
        }
    }
}