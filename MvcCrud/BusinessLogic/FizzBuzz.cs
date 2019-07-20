using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrud.BusinessLogic
{
    public class FizzBuzz
    {
        public string Print(int input)
        {
            var result = string.Empty;

            for (int i = 1; i <= input; i++)
            {
                if (i > 1)
                    result += ", ";

                result += Generate(i);
            }

            return result;
        }

        private string Generate(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            else if (i % 3 == 0)
                return "Fizz";
            else if (i % 5 == 0)
                return "Buzz";
            else
                return i.ToString();
        }
    }
}
