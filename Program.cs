namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");
            EmailPattern pattern = new EmailPattern();
            Console.WriteLine("please enter the pattern");
            string email = Console.ReadLine();

            bool value = pattern.ValidateEmail(email);

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
