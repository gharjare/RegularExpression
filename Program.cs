namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");

            NuminPass password = new NuminPass();

            Console.WriteLine("please enter the pattern");
            string Numeric = Console.ReadLine();

            bool value = password.ValidateNumeric(Numeric);

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
