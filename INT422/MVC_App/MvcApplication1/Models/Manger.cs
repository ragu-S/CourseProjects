using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Manger
    {
        public Person getPerson()
        {
            Person p = new Person("Jon", "Snow", "555-555-5555");
            
            return p;

        }

        public IEnumerable<Person> getPeople()
        {
            Person p = new Person("Jon", "Snow", "555-555-5555");
            Person d = new Person("Jane", "Doe", "555-555-5000");

            List<Person> ps = new List<Person>();
            ps.Add(p);
            ps.Add(d);

            return ps;
        }
    }
}