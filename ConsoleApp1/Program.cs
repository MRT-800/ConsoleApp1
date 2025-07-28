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



/*
using System;
class Program
{
    public static void Main(string[] args)
    {
         int age = 20;
         string name = Console.ReadLine();
         Console.WriteLine($"YOUR NAME IS : {name}, Age: {age}");
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

*/

/*
using System;
using System.ComponentModel;
namespace ConsoleApp1{
class program
{
    static void Main(string[] args)
    {
        bool value = true;
            bool isman = true;
            Console.WriteLine(isman);

            int a = 20;
            a++;
            a += 1;
            Console.WriteLine(a);

            Char c= 'A'; // Character data type
            char d = 'B'; // Character data type
            Console.WriteLine(c+d);       //Ascii value of A is 65 and B is 66 
            Console.WriteLine(65+66); 

        }
}

}*/


/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10; b = 2;
            c = a % 3; // Modulus operator gives the remainder of the division
            Console.WriteLine("remainder :" + c);


            var name = "Abhishek"; // var keyword is used to declare a variable without specifying its type(dont need to specify int or double or string)
            var d = 10.5; // d is a double type variable
            var e = 'e'; // e is a char type variable
            var isstudent = true; // f is a bool type variable
            var l = 1234567L; // l is a long type variable
            var money = 100.50m; // money is a decimal type variable, m at the end indicates it's a decimal

            Console.WriteLine($"Name: {name}, d: {d}, e: {e}, is he student: {isstudent}, long : {l}, decimal: {money}");


            const int vat = 15; // const keyword is used to declare a constant variable, its value cannot be changed
            Console.WriteLine($"VAT is : {vat}");
            //vat = 20; // This will give an error because vat is a constant variable and its value cannot be changed
            Console.WriteLine(166 * (vat / 100D));
        }
    }
}
*/

/*
using System;
 namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = (float)(a / b);
            Console.WriteLine($"{c:F10}");

        }
    }
}
*/


/*
using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two no. :");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            int result = a * b;
            while (true)
            {
                Console.WriteLine("guess the multiplication of two no :");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == result)
                {
                    Console.WriteLine("you guessed correct");
                    break;
                }
                else if (guess > result)
                {
                    Console.WriteLine("you guessed high");
                }
                else
                {
                    Console.WriteLine("you guessed low");

                }
            }
        }
    }
}*/


/*

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a driving licence? (y/n)");
            var input = Console.ReadLine();
            var hasit = input == "y";

             if (age >= 80)
            {
                Console.WriteLine($"Too old, please don't Drive ");
            }
            else if (age >= 18 && hasit)
            {
                Console.WriteLine($"Drive");
            }
            else if (age >= 18 && !hasit)
            {
                Console.WriteLine($"You can apply for a driving licence");
            }
            else if (age < 18)
            {
                Console.WriteLine($"You cannot drive yet.");
            }
            else
            {
                Console.WriteLine($"Please enter correct input ");
            }
        }
    }
}

*/


/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day : ");
            var day = Convert.ToInt32(Console.ReadLine());

            switch(day){
                case 1:
                    Console.WriteLine("Sunday (Rush Hour)");
                    break;
                case 2:
                    Console.WriteLine("Monday (Rush Hour)");
                    break;
                case 3:
                    Console.WriteLine("Tuesday (Busy Schedule)");
                    break;
                case 4:
                    Console.WriteLine("Wednesday (Busy Schedule)");
                    break;
                case 5:
                    Console.WriteLine("Thrusday (Half Day)");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekends");
                    break;
                default:
                    Console.WriteLine("Please, enter correct input !!! ");
                    break;

            }

        }
    }
}
*/


/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a no:");
             var a =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();*/

/*for (int i=0; i<=a; i++)
{
    Console.WriteLine("hello"+" "+i);

}*/

/* do
 {
     Console.WriteLine("hello");//infinite loop if a is 0
 } while (a == 0);
*/

/*
int a = 0;
do
{
    Console.Write("Enter your age: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 18)
    {
        Console.WriteLine("you are young");
    }
} while (a < 18);

Console.WriteLine("Your age is 18 or above.");


}
}
}
*/


/*
using System;
using System.Data.SqlTypes;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no.");
            var a = Convert.ToInt32(Console.ReadLine());
            String age = a >= 20 ? "You can Buy Drinks" : "Invalid age";
            Console.WriteLine(age);

            Console.WriteLine(a >= 100 ? "Died" : "Ok");//we can write it directly here

            double div = 22D / 7D;
            Console.WriteLine(div);
            div = -Math.PI;
            Console.WriteLine($"{div:F10}");

            //OR

            Console.WriteLine("Value of PI is : {0:0.000}", div);
            Console.WriteLine(div.ToString("C"));    // C is used to format the number as currency

        }
    }
}
*/

/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            { 
            Console.WriteLine("Enter a no:");
            string no = Console.ReadLine();
            int n = 0;
            if (int.TryParse(no, out n))
            {
                 //success =fales ;  //It also can  Exit the loop if input is valid
                    Console.WriteLine("You entered a valid number: " + n);
                    break; // Exit the loop if input is valid

                }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            
            
            }

            }
        }
    }
}*/

/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two no:");
            string no = Console.ReadLine();
            String no2 = Console.ReadLine();
            bool inp=int.TryParse(no, out int n); // TryParse returns true if conversion is successful, false otherwise
           bool inp2= int .TryParse(no2, out int n2);

            if(inp && inp2)
            {
                Console.WriteLine("The multiplication of "+n+" And "+ n2+ " is :"+n*n2 );
            }
            else {                 Console.WriteLine("Invalid input, please enter valid numbers.");  }
        }
    }
}
*/


/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no:");
            string no = Console.ReadLine();
            bool isno = int.TryParse(no, out int n); // TryParse returns true if conversion is successful, false otherwise

            if (isno)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i + " * " + n + " = " + i * n);
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");

            }
        }
    }
}

*/


/*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no:");
            string no = Console.ReadLine();
            bool isno = int.TryParse(no, out int n);
            if (isno)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FIZZBUZZ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("FIZZ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("BUZZ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }


                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }
} 
*/


/*
using System;
    namespace ConsoleApp1
{
    public class program
    {
        static void Main(string[] args)
           
        {
            string name =@" ""Android"" ";
           Console.WriteLine("hello\"this is it\" ");
            Console.WriteLine(name);
            Console.WriteLine("your name is "+name + "\nyou are 1 year old\t"+"you are bot");
            int age = 20;
            Console.WriteLine("your age is {0} and your name is {1}", age, name);
            Console.WriteLine($"your name is {name} and age is {age}, speed 100 terahertz, memory 100 zetabyte");
        }
    }
}
*/


/*
using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 names: ");
            string name = Console.ReadLine();
            string nom= Console.ReadLine();
            // Compare two strings
            if (name.Equals(nom))
            {
                Console.WriteLine("same name");
            }
            else
            {
                Console.WriteLine("not same name");
            }


        }
    }
}

*/


/*

using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 names: ");
            string name = Console.ReadLine();
            string nom = Console.ReadLine();
            // Compare two strings
            if (!name.Equals(nom))
            {
                Console.WriteLine("different");
            }
            else
            {
                Console.WriteLine(" same name");
            }


        }
    }
}
*/


/*
using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a names: ");
            string name = Console.ReadLine();
           
            
            if (name!=String.Empty)
            {
                Console.WriteLine($"{name}");
            }
            else
            {
                Console.WriteLine($"Hello, enter name ");
            }


        }
    }
}
*/



using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEBUG VERSION 1 ==="); // Add this line
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}
