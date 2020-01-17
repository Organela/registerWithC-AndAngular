using System;
using System.Net;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc;

using Register.Domain.Entities;
using Register.Domain.Repositories;
using Register.Domain.Services;

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
            var persons = PersonRepository.GetAll();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = PersonRepository.GetById(id);

            if (person == null)
            {
                NotFound();
            }

            return Ok(person);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = PersonRepository.GetById(id);

            if (person == null)
            {
                NotFound();
            }

            PersonRepository.Delete(person);

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Person person)
        {
            if(new PersonRegistrationService(PersonRepository).Register(person))
            {
                return Ok(CreatedAtAction(nameof(person), new { id = person.Id }, person));
            }
            else
            {
                return Ok(NotFound());
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Person person)
        {
            if (PersonRepository.GetById(id) == null)
            {
                return Ok(NotFound());
            }
            else
            {
                person.Id = id;
                PersonRepository.Update(person);
                return Ok();
            }
        }
    }
}