namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");

            UpperCase upperCase = new UpperCase();
            Console.WriteLine("please enter the pattern");
            string Upper = Console.ReadLine();

            bool value = upperCase.ValidateUpper(Upper);

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
