using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        //Requirements : 
        //1 . Trim whitespace  at left and right of the input
        //2. Trim whitespace inside input

        public static string RemoveWhiteSpace(string input)
        {
            input = input.Trim();

            string newInput = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' && input[i + 1] == ' ')
                {
                    continue;


                }
                newInput += input[i];
            }


            return newInput;
        }
    }
}