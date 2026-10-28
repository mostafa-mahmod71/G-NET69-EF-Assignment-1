using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFC01.Entities
{
    internal class Author
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Biograghy { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
