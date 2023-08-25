using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class MathMenu
    {
        public static int Add(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

            public static int Subtract(int num1, int num2) { return num1 - num2; }

        public static int Divide(int num1, int num2) { return num1 / num2; }

        public static int Multiply(int num1, int num2) { return num1 * num2; }
    }
}
