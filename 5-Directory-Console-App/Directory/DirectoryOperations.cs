using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    abstract class DirectoryOperations
    {
        public abstract List<Person> GetPersonList();
        public abstract string AddNewPerson(Person person);
        public abstract string DeletePerson(Person person);
    }
}
