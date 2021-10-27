using System;
using System.Collections.Generic;

namespace Activity4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            Console.Clear();

            do {
                Console.WriteLine("Contact List\nEnter one of the following commands:");
                Console.WriteLine("add <Name> <Number>");
                Console.WriteLine("update <Old Number> <Updated Name> <New Number>");
                Console.WriteLine("delete <Number>");
                Console.WriteLine("find <Name>");
                Console.WriteLine("or 'exit' to end");

                string command = Console.ReadLine();
                string[] input = command.Split(" ");

                if(input[0]=="add")
                {
                    if(!contacts.Exists(contact => contact.name == input[1]))
                    {
                        contacts.Add(new Contact(input[1], input[2]));
                    }
                    else
                    {
                        for(int i = 0; i < contacts.Count; i++)
                        {
                             string name = contacts[i].GetName();
                             if(name == input[1])
                             {
                                 contacts[i].AddNumber(input[2]);
                             }
                        }

                    }
                }
                else if(input[0] == "update")
                {
                    for(int i = 0; i < contacts.Count; i++)
                    {
                        List<string> phoneNumbers = new List<string>();
                        phoneNumbers = contacts[i].GetNumbers();

                        for(int j = 0; j < phoneNumbers.Count; j++)
                        {
                            if(phoneNumbers[j] == input[1])
                            {
                                contacts[i].Update(input[1], input[2], input[3]);
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
