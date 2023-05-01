using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{
    public class AccessModifiers
    {
        //Access modifier-Public-Can access anywhere within same assembly or another assembly.
        public int number=200;
        public void PublicMethod()
        {
            Console.WriteLine("The number is: "+number);
        }
        //Access modifier-Private-Can access within same class.
        private int number_Two = 400;
        private void PublicMethodTwo()
        {
            Console.WriteLine("The number is: " + number_Two);
        }
        //Access modifier-Protected-Can access within the same class and any derived class.
        protected int number_Three;
        protected void PublicMethodThree()
        {
            Console.WriteLine("This is example of protected access modifier");
        }
        //Access modifier-Internal-Can access within the same assembly
        internal int number_Four=500;
        internal void PublicMethodFour()
        {
            Console.WriteLine("Example of internal access modifier and the number is: "+number_Four);
        }
    }
    public class DeriveClass:AccessModifiers
    {
        public void DerivedMethod()
        {
            number_Three = 10;
            PublicMethodThree();
        }
    }
}
