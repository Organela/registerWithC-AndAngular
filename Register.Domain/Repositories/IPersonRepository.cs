using Register.Domain.Entities;
using System.Collections.Generic;

namespace Register.Domain.Repositories
{
    public interface IPersonRepository
    {
        IList<Person> GetAll();
        Person GetById(int id);
        void Save();
        void Update(Person person);
        void Add(Person person);
        void Delete(int id);

    }
}
