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

        public void Delete(Person person)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                session.Delete(person);
                session.BeginTransaction().Commit();
            }
        }

        public Person GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var person = session.Get<Person>(id);
                return person;
            }
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person person)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                session.Update(person);
                session.BeginTransaction().Commit();
            }
        }
    }
}
