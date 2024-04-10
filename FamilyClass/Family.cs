using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyClass
{
    public class Family
    {
        public List<Person> people = new List<Person>();

        public void Print()
        {
            foreach (Person person in people)
            {
                person.PrintPerson();
            }
        }
    }
}
