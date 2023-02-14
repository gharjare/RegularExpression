namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");
            LastName firstName = new LastName();
            Console.WriteLine("please enter the pattern");
            string name = Console.ReadLine();

            bool value = firstName.ValidateName(name);

            if (value)
            {
                Console.WriteLine("pattern is match");
            }
            else
            {
                Console.WriteLine("pattern is not match");
            }
        }
    }
}
