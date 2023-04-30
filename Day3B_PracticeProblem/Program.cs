namespace Day3B_PracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            TypesConstructors typesConstructors = new TypesConstructors();
            TypesConstructors types=new TypesConstructors(145,"Mansi");
            TypesConstructors typesTwo = new TypesConstructors(types);
        }
    }
}
