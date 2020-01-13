using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Domain.Entities
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Email { get; set; }
        public virtual string State { get; set; }
        public virtual string City { get; set; }
    }
}
