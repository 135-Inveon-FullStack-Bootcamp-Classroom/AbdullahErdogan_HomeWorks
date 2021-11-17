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
        public long Number { get { return _number; } set {
                if (value.ToString().Length != 10)
                {
                    Console.WriteLine("Please enter 10 digit for telephone number");
                }
                else
                {
                    _number = value;
                }
            } }

        public Person(string name,long number)
        {
            _name = name;
            _number = number;
        }
    }
}
