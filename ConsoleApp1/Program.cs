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

