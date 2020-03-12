using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTemplate.Models{
    public class GetPerson
    {
        public int PersonId { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        bool IsActive { get; set; }
    }
}