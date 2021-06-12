using System;

namespace TheGreatestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, largest;

            Console.WriteLine("Please enter number1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number3");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                largest = n1;
            else if (n2 > n1 && n2 > n3)
                largest = n2;
            else
                largest = n3;


            Console.WriteLine("The largest number among {0}, {1} and {2} is {3}", n1, n2, n3, largest);
            Console.ReadKey();


        }
    }
}
