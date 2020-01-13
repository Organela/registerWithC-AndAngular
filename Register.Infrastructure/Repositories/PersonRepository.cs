using Register.Domain.Repositories;
using System.Collections.Generic;
using Register.Domain.Entities;

namespace Register.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IList<Person> Create()
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> Delete()
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

        public IList<Person> GetById()
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> Save()
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
