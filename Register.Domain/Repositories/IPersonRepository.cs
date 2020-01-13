using Register.Domain.Entities;
using System.Collections.Generic;

namespace Register.Domain.Repositories
{
    public interface IPersonRepository
    {
        IList<Person> GetAll();
        IList<Person> GetById();
        IList<Person> Save();
        IList<Person> Update();
        IList<Person> Create();
        IList<Person> Delete();

    }
}
