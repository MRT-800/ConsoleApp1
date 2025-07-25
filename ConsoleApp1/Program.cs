//using System;
/*
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(); // Waits for key press
        }
    }
}*/


/*
namespace ConsoleApp1
{

    internal class Name
    {
        public int age = 20;
        public string name = "ABHISHEK";
        public string address = "Kathmandu";
        public double height = 5.5;
        public bool isStudent = true;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Name person = new Name();
            Console.WriteLine(person.isStudent);
            Console.WriteLine($"NAME : {person.name}, AGE: {person.age}, ADDRESS: {person.address}");
        }
    }

}
*/

/*
using System;
namespace ConsoleApp1
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert. ToInt32(Console.ReadLine());
            Console.WriteLine($"Age is {age}");

        }
    }
   
}
*/


/*
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age :");
            int age =Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Drive");
            }
            else
            {
                                Console.WriteLine("Don't Drive");
            }

        }
    }
}

*/



/*
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            try
            {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("You can drive");
                }
                else
                {
                    Console.WriteLine("You cannot drive");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for using program !");
            }
        }
    }
}
*/


/*
using System;

namespace consoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");


            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (i = 0; i < a; i++)
            {
                a = (a - 1) + (a - 2);
               
                Console.WriteLine($"The value of a is: {a}");


            }

        }

    }
}*/




using System;
class Program
{
    public static void Main(string[] args)
    {
        /* int age = 20;
         string name = Console.ReadLine();
         Console.WriteLine($"YOUR NAME IS : {name}, Age: {age}");*/
        Console.WriteLine("hello");

        long a = 123456;// int 32

        long no = 1234567L;// int 64 because of L at the end

        long c = a + no;// 

        Console.WriteLine(c);

        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        double d = 12.34; // double is a floating point number
        float f= 12.00000000034f; // float is also a floating point number but with less precision
        float e = (float)(d + f);
        Console.WriteLine($"{e:F10}"); // F10 means upto 10 decimal places

        decimal dec = 10.00123m; // decimal is a high precision floating point number, m at the end indicates it's a decimal
        decimal dec2 = 10.00123m;// use for Financial calculations
        Console.WriteLine(dec+dec2);

        String number = "123";
        int no1= Convert.ToInt32(number); // Convert string to int
        Console.WriteLine(no1);


        Console.WriteLine("Enter a no: ");
        int no2 = Convert.ToInt32(Console.ReadLine());// Convert user input string to int directly
        Console.WriteLine(no2);




    }
}
