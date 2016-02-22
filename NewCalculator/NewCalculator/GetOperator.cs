using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    public class GetOperator
    {
        public string Symbol()
        {
            Console.WriteLine("Input either:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            string response = Console.ReadLine();
            return response;
        }
        public double Choice(int x, int y, string z)
        {
            Operator O;
            switch (z)
            {
                case ("+"):
                    O = new Add(x, y);
                    double answer = O.Addition(x, y);
                    return answer;
                case ("-"):
                    O = new Subtract(x, y);
                    double answer2 = O.Subtraction(x, y);
                    return answer2;
                case ("*"):
                    O = new Multiply(x, y);
                    double answer3 = O.Multiplication(x, y);
                    return answer3;
                case ("/"):
                    O = new Divide(x, y);
                    double answer4 = O.Division(x, y);
                    return answer4;
                default:
                    Console.WriteLine();
                    return 0;

            }
        }
        
    }
}
