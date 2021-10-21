using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Calc();
        }

        class Calculator
        {
            public void Calc()
            {
                while (true)
                {
                    Console.WriteLine($"Hello i am a calculator\n");

                    Console.Write("Please enter the first number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Select expression '+' '-' '*' '/' : ");
                    string action = Console.ReadLine();

                    Console.Write("Please enter the second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case "+":
                            Console.Write("Your answer: ");
                            Console.WriteLine(firstNumber + secondNumber);
                            break;
                        case "-":
                            Console.Write("Your answer: ");
                            Console.WriteLine(firstNumber - secondNumber);
                            break;
                        case "*":
                            Console.Write("Your answer: ");
                            Console.WriteLine(firstNumber * secondNumber);
                            break;
                        case "/":
                            if (secondNumber == 0)
                            {
                                Console.Write("Your answer: ");
                                Console.WriteLine(0);
                            }
                            else
                            {
                                Console.Write("Your answer: ");
                                Console.WriteLine(firstNumber / secondNumber);
                            }
                            break;
                        default:
                            Console.WriteLine("You entered a wrong expression!");
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    
                }

            }

        }

    }
}
