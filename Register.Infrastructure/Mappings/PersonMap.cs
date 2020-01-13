using FluentNHibernate.Mapping;
using Register.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Infrastructure.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            Id(x => x.Id, "Id").GeneratedBy.Identity().UnsavedValue(0);
            Map(x => x.Name);
        }
    }
}
