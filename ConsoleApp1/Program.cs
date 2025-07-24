using System;
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


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Name();
            person.Display();

            Console.ReadKey();
        }
    }

    internal class Name
    {
        private  int age = 20;
        private  string name = "ABHISHEK";
        private  string address = "Kathmandu";
        private  double height = 5.5;
        private  bool isStudent = true;

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is Student: " + isStudent);
        }
    }
}

