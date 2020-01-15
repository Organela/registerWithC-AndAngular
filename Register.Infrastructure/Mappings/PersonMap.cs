using FluentNHibernate.Mapping;
using Register.Domain.Entities;

namespace Register.Infrastructure.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
