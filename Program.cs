using System;
using System.Collections.Generic;

namespace Activity4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contact John = new Contact("John","56123789");
            // Contact Sean = new Contact("Sean", "783526549");
            // John.Add("4565631378");
            // John.Add("789321546");
            // John.Update("4565631378", "George", "125367984");
            // John.Delete("789321546");

            // List<string> listNumbers = new List<string>();  
            // listNumbers = John.GetNumbers();
            // Console.WriteLine(listNumbers[1]);

            List<Contact> contacts = new List<Contact>();

            do {
                Console.WriteLine("Contact List\nEnter one of the following commands:");
                Console.WriteLine("add <Name> <Number>");
                Console.WriteLine("update <Old Number> <Updated Name> <New Number>");
                Console.WriteLine("delete <Number>");
                Console.WriteLine("find <Name>");
                Console.WriteLine("or 'exit' to end");
                string command = Console.ReadLine();
                command = command.ToLower();
                string[] input = command.Split(" ");

                if(input[0]=="add")
                {
                    contacts.Add(new Contact(input[1], input[2]));
                }
                else if(input[0] == "update")
                {
                    foreach(var contact in contacts)
                    {
                        List<string> phoneNumbers = new List<string>();
                        phoneNumbers = contact.GetNumbers();
                        //lock(phoneNumbers)
                        foreach(string number in phoneNumbers)
                        {
                            if(number == input[1])
                            {
                                contact.Update(input[1], input[2], input[3]);
                            }
                        }
                    }
                }
                else if(input[0]=="delete")
                {
                    for(int i = 0; i < contacts.Count; i++)
                    {
                        List<string> phoneNumbers = new List<string>();
                        phoneNumbers = contacts[i].GetNumbers();

                        for(int j = 0; j < phoneNumbers.Count; j++)
                        {
                            if(phoneNumbers[j] == input[1])
                            {
                                contacts[i].Delete(input[1]);
                            }
                        }
                    }
                }
                else if(input[0] == "find")
                {
                    foreach(var contact in contacts)
                    {
                        string name = contact.GetName();
                        if(name == input[1])
                        {
                            contact.DisplayContact();
                        }
                    }
                }
                else if(input[0]=="exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again...");
                    break;
                }  
            } while(true);
        }
    }
}
