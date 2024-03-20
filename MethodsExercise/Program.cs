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
        }
    }
}
