using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorVS
{
    public class Handler
    {
        private Calculation _calculation;

        public Handler()
        {
            _calculation = new Calculation();
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to my Calculator!");
                Console.WriteLine("Please press 1 for Addition");
                Console.WriteLine("Please press 2 for Subtraction");
                Console.WriteLine("Please press 3 for Division");
                Console.WriteLine("Please press 4 for Multiplication \n");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter first number:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int y = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = _calculation.Add(x, y);
                            break;
                        }
                    case 2:
                        {
                            result = _calculation.Subtract(x, y);
                            break;
                        }
                    case 3:
                        {
                            result = _calculation.Divide(x, y);
                            break;

                        }

                    case 4:
                        {
                            result = _calculation.Multiply(x, y);
                            break;

                        }

                    default:
                        Console.WriteLine("Invalid action! Please try again!");
                        break;
                }

                Console.WriteLine("The result is {0}", result);
                Console.ReadLine();
                Console.Clear();


            }
        }
    }
}
