namespace RegularExpressionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");

            SpecialCharacter specialCharacter = new SpecialCharacter();
            Console.WriteLine("please enter the pattern");
            string Character = Console.ReadLine();

            bool value = specialCharacter.ValidateCharacter(Character);

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
