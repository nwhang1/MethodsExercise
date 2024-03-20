using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            // String interpolation request
            string intro = $"This is {name}, their favorite color is {color}, their favorite animal is {animal}, and their favorite band is {band}!";
            Console.WriteLine(intro);

            // Math Section
            Console.WriteLine("Let's do some math, Enter two numbers to add:");

            //From Googling, Parse converts strings into integers from user input 
            //Addition Method
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = Add(num1, num2);
            Console.WriteLine($"The answer is {sum}");

            //Subtraction Method
            Console.WriteLine("Now enter two numbers to subtract:");
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int sub = subtract(num3, num4);
            Console.WriteLine($"The answer is {sub}");

            //Multiply Method
            Console.WriteLine("Now enter two numbers to multiply");
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int mul = multiply(num5, num6);
            Console.WriteLine($"The answer is {mul}");

            //Divide Method
            Console.WriteLine("Now enter two numbers to divide, numerator first, don't make the denominator zero!");
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            int div = Divide(num7, num8);
            Console.WriteLine($"The answer is {div}");

            //Modulus Method
            Console.WriteLine("Now I'm going to show off, give me two numbers to multiply, then another number to add to the total");
            int num9 = int.Parse(Console.ReadLine());
            int num10 = int.Parse(Console.ReadLine());
            int num11 = int.Parse(Console.ReadLine());
            int mod = Modulus(num9, num10, num11);
            Console.WriteLine($"The answer is {mod}");
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        static int multiply(int num5, int num6) 
        { 
            return num5 * num6;
        }

        static int Divide(int num7, int num8) 
        {
            // From Googling, throw new is a method that is used for exceptions, in this case, if the user decides to attempt to divide by zero
            if (num8 == 0)
            {
                throw new DivideByZeroException("You can't divide by zero");
            }

            return num7 / num8;
        }

        static int Modulus(int num9, int num10, int num11)
        {
            return ((num9*num10)) + num11;
        }
    }
}
