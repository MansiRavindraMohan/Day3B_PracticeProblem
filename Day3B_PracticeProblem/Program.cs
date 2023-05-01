namespace Day3B_PracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Constructor Example
            TypesConstructors typesConstructors = new TypesConstructors();
            TypesConstructors types=new TypesConstructors(145,"Mansi");
            TypesConstructors typesTwo = new TypesConstructors(types);
            //Interface Example
            Shapes shapes=new Shapes();
            shapes.calculateArea(10, 20);
            shapes.getColor();
            //Access Modifiers
            DeriveClass deriveClass= new DeriveClass();
            deriveClass.DerivedMethod();
            deriveClass.PublicMethod();
            deriveClass.PublicMethodFour();
        }
    }
}
