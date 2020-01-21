using Register.Domain.Entities;
using System.Collections.Generic;

namespace Register.Domain.Repositories
{
    public interface IPersonRepository
    {
        IList<Person> GetAll();
        Person GetById(int id);
        void Save(Person person);
        void Update(Person person);
        void Create(Person person);
        void Delete(Person person);
    }
}
