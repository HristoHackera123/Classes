using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyClass
{
    public class Person
    {
        public string name;
        public int age;

        public void PrintPerson()
        {
            Console.WriteLine($"{this.name}  {this.age}");
        }
    }
}
