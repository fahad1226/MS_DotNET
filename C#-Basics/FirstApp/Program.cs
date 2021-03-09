using System;
using System.Collections.Generic;
using System.Collections;


namespace FirstApp
{
    class Program
    {
        static string Name(string name) {
            return name;
        }
        static int Name(int age) {
            return age; 
        }
        static void Main(string[] args)
        {

           // String name = Console.ReadLine();
           // Console.WriteLine(name);
            // string firstName = "John";
            // string lastName = "Doe";
            // string name = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);
            // Console.WriteLine(Math.Max(10, 20));

            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            // Console.WriteLine(cars[1]);

            // Name("Ryzen PC");
            // Console.WriteLine(Name(29823));

            List<int>numbers = new List<int>(); // etate type ta bole dite hobe, fixed
            numbers.Add(10);
            numbers.Add(20); 


            // numbers[0] = 30; we cannot use this in List or whatever collection
            // numbers[1] = 20;
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }

            ArrayList myFriends = new ArrayList(); // ArrayList e type na bolleo hobe, dynamic type arki JS er moto
            myFriends.Add("Ross");
            myFriends.Add(100);
            myFriends.Add("Joey");

            foreach(var friend in myFriends) {
                Console.WriteLine(friend);
            }
        }
    }
}
