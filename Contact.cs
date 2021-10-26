using System;
using System.Collections.Generic;

namespace Activity4._3._1
{
    public class Contact
    {
        public string name;
        public List<string> listNumbers = new List<string>();

        public Contact()
        {

        }
        public Contact(string name, string number)
        {
            this.name = name;
            this.listNumbers.Add(number);
        }
        public void Add(string newNumber)
        {
            this.listNumbers.Add(newNumber);
        }
        public void Update(string oldNumber, string newNumber)
        {
            this.listNumbers.Add(newNumber);
            this.listNumbers.Remove(oldNumber);
        }
        public void Delete(string numberToDelete)
        {
            this.listNumbers.Remove(numberToDelete);
        }
        public List<string> Get()
        {
            // Console.WriteLine($"{this.name}: ");
            // foreach(string number in this.listNumbers)
            // {
            //     Console.Write($"{number} ");
            // }
            // Console.WriteLine();
            return this.listNumbers;
        }
    }
}