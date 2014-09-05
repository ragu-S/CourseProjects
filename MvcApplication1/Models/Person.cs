using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Person
    {
        public Person() {
            FirstName = LastName = Phone = string.Empty;
        }
        public Person(string fName, string lName, string pNum)
        {
            LastName = lName;
            FirstName = fName;
            Phone = pNum;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        
    }
}