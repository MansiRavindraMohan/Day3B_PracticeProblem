using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day3B_PracticeProblem
{
    public class TypesConstructors
    {
        //Default Constructor
        public TypesConstructors() 
        {
            Console.WriteLine("This is example of default constructor");
        }
        //Parameterised Constructor
        public int Id;
        public string Name;
        public TypesConstructors(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("This is example of Parameterised constructor");
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
        //Copy Constructor
        public TypesConstructors(TypesConstructors other)
        {
            this.Id = other.Id;
            this.Name = other.Name;
            Console.WriteLine("This is example of Copy constructor");
            Console.WriteLine(other.Name);
            Console.WriteLine(other.Id);
        }
    }
}
