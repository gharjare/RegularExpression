namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");
            Password pattern = new Password();
            Console.WriteLine("please enter the pattern");
            string password = Console.ReadLine();

            bool value = pattern.ValidateNumeric(password);

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
