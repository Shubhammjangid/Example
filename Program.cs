using System;

namespace C // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function MyObj = new Function();
            Console.WriteLine("Enter the number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int B =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyObj.Addition(A,B));
            Console.WriteLine(MyObj.Subtraction(A,B));
        }
    }
}