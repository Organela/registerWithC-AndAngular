using Register.Domain.Repositories;
using System.Collections.Generic;
using Register.Domain.Entities;

namespace Register.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> GetAll()
        {
            return new List<Person>()
            {
                 new Person() { Name = "ba" }
            };
        }

        public Person GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}
