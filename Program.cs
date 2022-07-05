// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace OOP_Example{

    class Program{
        static void Main(string[] args)
        {
            // take Youtuber and Programmer objects to List
            List<Creator> creators = new List<Creator>() { new Youtuber() , new Programmer() };

            foreach(var creator in creators) //accessing the list items
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create(); //calling the same method with different implementation(Dynamic Polymorphism)
                Console.WriteLine();
            }
        }
    }
}
