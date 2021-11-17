using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public class Person : IPerson
    {
        private string _name;
        private long _number;
        public string Name { get => _name; set => _name=value; }
        public long Number { get => _number;  set {
                if (value.ToString().Length == 10)
                {
                    _number = value;
                }
                else
                {
                    Console.WriteLine("Please enter 10 digit for telephone number");
                }
            } }

        public Person(string name,long number)
        {
             Name = name;
             Number = number;
        }
    }
}
