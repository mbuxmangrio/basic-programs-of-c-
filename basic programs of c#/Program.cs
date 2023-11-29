namespace basic_programs_of_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic operators.
            int a = 80; int b = 60;
            var c = a + b;
            Console.WriteLine($"Addition (+): {c}");
            c = a - b;
            Console.WriteLine($"Substraction (-): {c}");
            c = a * b;
            Console.WriteLine($"Multiplication (*): {c}");
            c = a / b;
            Console.WriteLine($"Division (/): {c}");
            c = a % b;
            Console.WriteLine($"Modulo (%): {c}");
            //increment and decrement.
            int d = 5;
            Console.WriteLine(++d);
            Console.WriteLine(d++);
            Console.WriteLine(d);
            Console.WriteLine(--d);
            Console.WriteLine(d--);
            Console.WriteLine(d);
            //Assignment operators.
            int e = 45;int f = 45;var r = e += f;
            Console.WriteLine($"Addition : {e}");
            r = e -= f;
            Console.WriteLine($"Substraction : {e}");
            r = e *= f;
            Console.WriteLine($"Multiplication: {e}");
            r = e /= f;
            Console.WriteLine($"Division: {e}");
            r = e %= f;
            Console.WriteLine($"Modulo: {e}");
            //Relational or comparison operators.
            int g = 59; int h = 56; var i = g == h;
            Console.WriteLine($"Equal to: {i}");
            i = g != h;
            Console.WriteLine($"Not equal to : {i}");
            i = g > h;
            Console.WriteLine($"Greater than: {i}");
            i = g >= h;
            Console.WriteLine($"Greater than or equal to: {i}");
            i = g < h;
            Console.WriteLine($"Less than: {i}");
            i = g <= h;
            Console.WriteLine($"Less than or equal to: {i}");
            // logical operators.
            int w = 40;
            int x = 50;
            bool z = w == 30 || x == 50;
            Console.WriteLine(z);

































        }
    }
}