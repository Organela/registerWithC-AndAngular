using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Domain.DTO
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
