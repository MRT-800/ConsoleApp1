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
namespace consoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any char");
            char ch = Console.ReadKey().KeyChar;
            switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"\n{ch} is a vowel");
                    break;
                default:
                    Console.WriteLine($"\n{ch} is a consonant");
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


/*
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
*/


/*
using System;
using System.Threading;

namespace DeathClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Death Clock";
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your birth date:");

            Console.Write("Year (e.g. 2002): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Day (1-31): ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate;
            try
            {
                birthDate = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine(" Invalid date entered.");
                return;
            }
            Console.WriteLine("enter life expetency of your country");
            int lifeExpectancy = Convert.ToInt32(Console.ReadLine());
            int bonusYears = 0;

            Console.Write("Do you smoke? (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes") bonusYears -= 10;

            Console.Write("Do you exercise regularly? (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes") bonusYears += 5;

            Console.Write("Do you sleep 7-8 hrs daily? (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes") bonusYears += 2;
            else bonusYears -= 2;

            Console.Write("Are you often stressed? (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes") bonusYears -= 3;

            Console.Write("Did your parents/grandparents live 85+? (yes/no): ");
            if (Console.ReadLine().ToLower() == "yes") bonusYears += 3;

            int finalAge = lifeExpectancy + bonusYears;
            DateTime deathDate = birthDate.AddYears(finalAge);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your estimated death date: " + deathDate);

            while (true)
            {
                TimeSpan timeLeft = deathDate - DateTime.Now;

                if (timeLeft.TotalSeconds <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine(" Your time has come...");
                    Console.WriteLine(@"
       _______
    .-'       `-.
   /           \
   |     RIP       |
   |            |
   |      |
   |            |
   |____________|
  //            \\
 ^^              ^^
"+"    "+name);
                    break;
                }

                Console.SetCursorPosition(0, 2);
                Console.WriteLine(" Seconds left to live: " + $"{(long)timeLeft.TotalSeconds:N0}      ");

                Thread.Sleep(1000);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

*/


//GPT version code .........
/*

using System;
using System.Globalization;
using System.Threading;

namespace DeathClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "☠️ Live Death Clock Countdown ☠️";

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim().ToLower());

            Console.WriteLine("\nEnter your birth date:");
            int year = ReadInt("Year (e.g. 2002): ", 1900, DateTime.Now.Year);
            int month = ReadInt("Month (1-12): ", 1, 12);
            int day = ReadInt("Day (1-31): ", 1, 31);

            DateTime birthDate;
            try
            {
                birthDate = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("❌ Invalid date entered.");
                return;
            }

            int lifeExpectancy = ReadInt("\nEnter life expectancy of your country: ", 30, 130);
            int bonusYears = 0;

            bonusYears += AskYesNo("Do you smoke?") ? -10 : 0;
            bonusYears += AskYesNo("Do you exercise regularly?") ? 5 : 0;
            bonusYears += AskYesNo("Do you sleep 7-8 hrs daily?") ? 2 : -2;
            bonusYears += AskYesNo("Are you often stressed?") ? -3 : 0;
            bonusYears += AskYesNo("Did your parents/grandparents live 85+?") ? 3 : 0;

            int finalAge = lifeExpectancy + bonusYears;
            DateTime deathDate = birthDate.AddYears(finalAge);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Estimated Death Date for {name}: {deathDate}");

            while (true)
            {
                TimeSpan timeLeft = deathDate - DateTime.Now;

                if (timeLeft.TotalSeconds <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("💀 Your time has come...");
                    Console.WriteLine(@"
       _______
    .-'       `-.
   /           \\
   |    R  I  P   |
   |             |
   |  " + name.PadRight(11) + @"|
   |             |
   |_____________|
  //             \\
 ^^               ^^
");
                    break;
                }

                string formatted = FormatTimeLeft(timeLeft);

                Console.SetCursorPosition(0, 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⏳ Time left: " + formatted + "                    ");

                if (timeLeft.TotalSeconds < 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("⚠️ Almost there, prepare for your fate...");
                }

                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Format TimeSpan nicely
        static string FormatTimeLeft(TimeSpan span)
        {
            int years = span.Days / 365;
            int days = span.Days % 365;
            Console.Beep(400, 300);
            return $"{years}y {days}d {span.Hours}h {span.Minutes}m {span.Seconds}s";
        }

        // Read an int with bounds and validation
        static int ReadInt(string prompt, int min, int max)
        {
            int val;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out val) && val >= min && val <= max)
                    return val;
                Console.WriteLine($" Please enter a valid number between {min} and {max}.");
            }
        }

        // Yes/no question → bool
        static bool AskYesNo(string question)
        {
            Console.Write(question + " (yes/no): ");
            string ans = Console.ReadLine().ToLower();
            return ans == "yes" || ans == "y";
        }
    }
}
*/

/*
using System;
using System.Threading;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
           string name = "MRT 800";
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(name[3]);
            //Console.WriteLine(name[4]);
            //Console.WriteLine(name[5]);
            //Console.WriteLine(name[6]);
            //Console.WriteLine("\n");

            // Using a loop to print each character in the string
            for (int i=0; i<name.Length; i++)
            {
                Console.WriteLine(name[i]);
                Console.Write(name[i]);
                Thread.Sleep(500); // Adding a delay of 500 milliseconds between each character

            }
           

        }
    }
}
*/

/*

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 5, 6 };

        // Ascending order
        Array.Sort(numbers);
        Console.WriteLine("Ascending: " + string.Join(", ", numbers));

        // Descending order
        Array.Reverse(numbers);
        Console.WriteLine("Descending: " + string.Join(", ", numbers));
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
            int[ , ] a = { { 11, 21, 32 },{ 45, 57, 60 }, { 12, 14, 15 }, { 14,16,96} };
            for (int i = 0; i<4;i++)  // rows 
            {
                for (int j = 0; j < 3; j++) // columns

                    Console.Write(a[i, j] + " ");
                
                Console.WriteLine();
            }
            
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
            int[][] a = new int[3][];
            a[0]= new int[2] { 1, 2 };
            a[1] = new int[3] { 3, 4,5 };
            a[2] = new int[4] { 6, 7,8,9 };
            for(int i=0; i<a.Length; i++)
            {
                for (int j=0; j<a[i].Length; j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }


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
            int[][] a = new int[3][];
            a[0] = new int[2] { 1, 2 };
            a[1] = new int[3] { 3,4,5 };
            a[2] = new int[4] { 6, 7, 8, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }

}
*/

/*
using System;
namespace ConsoleApp1 {
    public class  program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(",", a1));

            Object[] a = { 1, "hello", 'a', 4.5 }; //object array can hold different data types
            Console.WriteLine("Original array: " + string.Join(", ", a));
            Array.Reverse(a);
            Console.WriteLine("Reversed array: " + string.Join(", ", a));
        }

    }

}
*/

/*

using System;
namespace ConsoleAPp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            int[] a = { 3, 4, 5, 6, 7, 8 , 9 , 15,17, 23,33,51,97 };
            
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(n); j++) // Check divisibility up to the square root of n
                {
                    if (n % j == 0)
                    {
                        prime = false;
                        break; // No need to check further, n is not prime
                    }
                   
                }
                if (prime)
                {
                    Console.WriteLine(a[i]+" is  prime");
                }
                else
                {
                    Console.WriteLine("not a prime = " + a[i]);
                }
            }
        }
    }
}
*/

/*

//class , object, method, encapsulation
using System;
namespace ConsoleApp1
{
       public class program
    {
        private int roll; 
        private string name;

        public void accept(int roll, string name) // this is a method
        {
            this.roll = roll;
            this.name = name;
        }
        public void display() //this is another method
        {
            Console.WriteLine($"Name: {name}, Roll: {roll}");
        }
        static void Main(string[] args)
        {
            program student = new program(); //cerating object for class program
            student.accept(101, "Abhishek");
            student.display();

            program std2 = new program(); // multiple object
            std2.accept(102,"Andy");
            std2.display();
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
        private int roll;
        private string name;

        program(){

            roll = 1;
            }
        public void take(string name)
        {
                        this.name = name;
        }
        public void diaplay()
        {
            Console.WriteLine("name is  {0} and age is {1}", name, roll );
        }

        static void Main(string[] args)
        {
            program student = new program(); //cerating object for class program
            student.take("abc");
            student.diaplay();
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
        private int roll;
        private string name;
        program()
        {
            roll = 1;
        }
        program(string name):this() // constructor overloading, chaining (join 2 constructor)
        {
            
            this.name = name;
        }

        public void diaplay()
        {
            Console.WriteLine("name is  {0} and age is {1}", name, roll);
        }
        static void Main(string[] args)
        {
            program student = new program("\nabc\n"); //cerating object for class program
            
            student.diaplay();
        }
    }
}
*/


/*
using System;

namespace ConsoleApp1
{
    abstract class Bank  // abstract class
    {
        internal int b = 5000;

        public abstract void Credit(int amt);
        public abstract void Debit(int amt);
        public abstract void Login(int code);
        public abstract void CheckBalance(int amt);

        public void Welcome() // non-abstract method
        {
            Console.WriteLine("Welcome to the bank");
        }
    }

    abstract class BankImplement : Bank
    {
        public override void Credit(int amt)
        {
            b += amt; // Use parameter instead of hardcoded 12000
        }

        public override void Debit(int amt)
        {
            b -= amt; // Use parameter instead of hardcoded 10000
        }

        public override void Login(int code)
        {
            if (code == 1234)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }

        public override void CheckBalance(int amt)
        {
            Console.WriteLine("Balance is " + b);
        }
    }

    abstract class Customer : Bank
    {
        public string Name;
        public int CustomerID;

        public Customer(string name, int id)
        {
            this.Name = name;
            this.CustomerID = id;
        }

        public void CustomerInfo()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer ID: " + CustomerID);
        }
    }

    class CustomerImplement : BankImplement
    {
        public string Name;

        public CustomerImplement(string name)
        {
            Name = name;
        }

        public void ShowCustomer()
        {
            Console.WriteLine("Customer: " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerImplement customer = new CustomerImplement("Abhi T");
            customer.Welcome();
            customer.Login(1234);
            customer.Credit(2000);
            customer.Debit(1000);
            customer.CheckBalance(0);
            customer.ShowCustomer();
        }
    }
}

*/



/*
using System;
using System.Diagnostics;
namespace ConsoleApp1
{
    internal class Animal
    {
        public Animal(string speak)
        {
            Console.WriteLine("Animal speaks = " + speak);
        }
        public virtual void Bark()
        {
            Console.WriteLine("animal barks");
        }
    }
    internal class Dog : Animal
    {
        public Dog() : base("Bark")
        {
            Console.WriteLine("barking dog");

        }
        public override void Bark()
        {
            Console.WriteLine("dog Barks baka!");
        }

        public static void Main(string[] args)
        {
            Animal d = new Dog();
            d.Bark();

        }
    }
}
*/


/*

using System;
namespace ConsoleApp1
{
    interface IAnimal
    {
        void Speak();
        void Eat();
    }

    interface Travel
    {
        void Travel();
    }
    public class Dog : IAnimal, Travel
    {
        public void Speak()
        {
            Console.WriteLine("wooof wooof ");
        }
        public void Eat()
        {
            Console.WriteLine("Dog eats");
        }
        public void Travel()
        {
            Console.WriteLine("Running");
        }

    }
    public class Cat : IAnimal, Travel
    {
        public void Speak()
        {
            Console.WriteLine("mew meeeew");
        }
        public void Eat()
        {
            Console.WriteLine("Cat eats");
        }
        public void Travel()
        {
            Console.WriteLine("Jumping");
        }
    }

        public class program
        {
            static void Main(string[] args)
            {
                IAnimal d = new Dog();
                d.Eat();
                d.Speak();
                Travel t = new Dog();
                t.Travel();
                IAnimal c = new Cat();
                c.Eat();
                c.Speak();
                Travel t1 = new Cat();
                t1.Travel();

            }

        }
    
}

*/

/*
using System;
using System.Threading.Channels;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {

            try
            {
                double a, b, c;
            Console.WriteLine("enter 2 no. ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

                    c = (a / b);
                Console.WriteLine(c);
            }
            catch(FormatException ex) {
                Console.WriteLine("enter numbers only");
            }
            catch (DivideByZeroException e) { 
            Console.WriteLine("Error. please enter valid numbers.");
            }
            finally
            {
                Console.WriteLine("program successfully execute");
            }

        }
    }
}
*/

/*
using System;
using System.Collections;
namespace App1
{
    public class program 
    {
        public static void Main(String[] Args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3.623);
            list.Add("hello");
            
            foreach (object items in list)
            {
                Console.WriteLine(items);
            }
            list.Remove(2);
            foreach (object items in list)
            {
                Console.WriteLine(items);
            }
        }
    }
}

*/


/*
using System;
using System.Collections;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Abhi");
            ht.Add(2, "Andy");
            ht.Add(3, "Amit");
            ht.Add(4, "Ankit");
            foreach (DictionaryEntry items in ht)
            {
                Console.WriteLine(items.Key + " " + items.Value);
            }
        }
    }

}

*/


/*

using System;
using System.Collections;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> ht = new Dictionary<int, string>();
            ht.Add(1, "Abhi");
            ht.Add(2, "Andy");
            ht.Add(3, "Amit");
            ht.Add(4, "Ankit");
            foreach (var items in ht)
            {
                Console.WriteLine(items.Key + " " + items.Value);
            }
        }
    }

}
*/

/*
using System;
using System.Collections;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push("hello");
            st.Push(3.14);
            st.Push('a');
            foreach (var items in st)
            {
                Console.WriteLine(items);
            }
            st.Pop();
            st.Pop();
            foreach (var items in st)
            {
                Console.WriteLine(items);
            }

        }
    }

}

*/



/*
using System;
using System.Collections;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            
            q.Enqueue("hello");
            q.Enqueue(3.14);
            q.Enqueue('a');
            foreach (var items in q)
            {
                Console.WriteLine(items);
            }
            q.Dequeue();
            q.Dequeue();
            foreach (var items in q)
            {
                Console.WriteLine(items);
            }

        }
    }

}
*/




/*
using System;
using System.Collections;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            FileInfo fo =new FileInfo("C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt");
            FileStream fs = fo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hello this is abhi");
            sw.Close();
            Console.WriteLine("file edit");
        }

    }
}

*/


// write all text use in file  (replace previous contents)
/*
using System;
using System.IO;
namespace ConsoleApp1 { 
public class program
    {
        public static void Main(string [] args)
        {
            String path = "C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt";
            string content= "привет, это я MR.T-800 ";
            File.WriteAllText(path, content);
            Console.WriteLine("file created and modified ");
        }

    }
}

*/

//append all text use in file(add more info on same)
/*
using System;
using System.IO;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            String path = "C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt";
            string content = "yes this is me mrt 800 ";
            File.AppendAllText(path, content);
            Console.WriteLine("file created and modified ");
        }

    }
}
*/


//read all text use in file
/*
using System;
using System.IO;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            String path = "C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt";
            string content = File.ReadAllText(path);
            
            Console.WriteLine("File content : "+content);
        }

    }
}*/




//use of stream writer to write in file
/*
 
using System;
using System.IO;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            String path = "C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt";
            string[] content = File.ReadAllLines(path);
            using (StreamWriter sw = new StreamWriter(path,true)) //true is used to append the text
            {
                sw.WriteLine("i am abhi t  ");
            }
            Console.WriteLine("Added");
        }

    }
}

*/



//use of stream reader to read from file

/*
using System;
using System.IO;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\abhis\\OneDrive\\Desktop\\file.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line=sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

*/



//delegates(function pointer) and events 


/*
using System;
namespace ConsoleApp1
{
    internal class program
    {
        public void Function()
        {
            Console.WriteLine("Function");
        }

        public void Function1()
        {
            Console.WriteLine("Function1");
        }


        public delegate void del(); //delegate declaration
        static void Main(string[] args)
        {
            program program = new program();
            del de = new del(program.Function); //delegate instantiation
            de+=program.Function1; //delegate call
            de(); //delegate call
            de-= program.Function; //remove function from delegate
            de();
            Console.WriteLine();
        }
    }
}
*/



using System;
namespace ConsoleApp1
{
    public class program
    {
        public delegate String del(String s1, String S2);
        event del myevent;
        public program()
        {
            this.myevent += program_myEvent;
        }
        private string program_myEvent(string s1, string S2)
        {
            return s1 + S2;

        }
        public static void Main(string[] args)
        {
            program program = new program();
            string result = program.myevent(" abhi ", " t-800 ");
            Console.WriteLine(result);
        }
    }
}





