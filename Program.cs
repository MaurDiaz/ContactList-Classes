using System;
using System.Collections.Generic;

namespace Activity4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact John = new Contact("John","56123789");
            Contact Sean = new Contact("Sean", "783526549");
            John.Add("4565631378");
            John.Add("789321546");
            John.Update("4565631378", "125367984");
            John.Delete("789321546");

            List<string> listNumbers = new List<string>();
            listNumbers = John.Get();
            Console.WriteLine(listNumbers[1]);

            List<string> contacts = new List<string>();
            
            do {
                Console.WriteLine("Contact List\nEnter one of the following commands:");
                Console.WriteLine("add <Name> <Number>");
                Console.WriteLine("update <Old Number> <Updated Name> <New Number>");
                Console.WriteLine("delete <Number>");
                Console.WriteLine("find <Name>");
                Console.WriteLine("or 'exit' to end");
                string command = Console.ReadLine();
                string[] input = command.Split(" ");

                if 




            } while(true);
            //Sean.Get();
        }
    }
}
