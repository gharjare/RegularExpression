using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionProblem
{
    public class FirstName
    {
        public static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Regex_FirstName);
        }
    }
}
