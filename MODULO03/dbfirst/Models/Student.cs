using System;
using System.Collections.Generic;

namespace dbfirst.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassId { get; set; }
    }
}
