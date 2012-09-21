using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingDelegates
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get;  private set; }

        public void Say(string message)
        {
            Console.WriteLine("{0} says: {1}", Name, message);
        }
    }
}
