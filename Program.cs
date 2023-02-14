namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");
            MobNumber pattern = new MobNumber();
            Console.WriteLine("please enter the pattern");
            string number = Console.ReadLine();

            bool value = pattern.ValidateNumber(number);

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
