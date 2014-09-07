using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mf_intro.Models
{
    public class Manager
    {
        //do this first
        public Person getPerson()
        {
            Person p = new Person("John", "Smith", "555-555-5555");

            return p;
        }

        //do this after dealing with one object
        public IEnumerable<Person> getPeople()
        {
            Person p = new Person("John", "Smith", "555-555-5555");
            Person b = new Person("Jane", "Doe", "555-555-0000");

            List<Person> ps =  new List<Person>();
            ps.Add(p);
            ps.Add(b);

            return ps;
        }

    }
}