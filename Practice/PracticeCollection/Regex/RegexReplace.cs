using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollection.Regex
{
    //Namespace for the Regex Class
    using System.Text.RegularExpressions;
    public class SolutionClass
    {
        public static string RegexReplace(string arg)
        {
            //Create a pattern to hold all alphanumeric characters
            string pattern = "[^0-9a-zA-Z]+";

            //Create a replacement: replaces the entire match with the first captured subexpression.
            string replacement = "";

            //Invoke replace method on regex class to remove all non alphanumeric characters
            return Regex.Replace(arg, pattern, replacement);
        }
    }
}
