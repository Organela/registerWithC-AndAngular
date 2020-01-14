using Register.Domain.Entities;
using Register.Domain.Repositories;
using Register.Infrastructure.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Register.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person person)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(person);
                    transaction.Commit();
                }
            }
        }

        public IList<Person> GetAll()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Person>().ToList();
            }
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Person GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var employee = session.Get<Person>(id);
                return employee;
            }
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
