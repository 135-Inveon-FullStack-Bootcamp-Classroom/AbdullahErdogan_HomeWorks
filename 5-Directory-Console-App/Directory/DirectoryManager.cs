using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class DirectoryManager : DirectoryOperations
    {
        private List<Person> DirectoryList = new List<Person>();

        public override string AddNewPerson(Person person)
        {
            DirectoryList.Add(person);
            ShowMessage message = new ShowMessage(true);
            return message.Message;
        }


        public override string DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public override List<Person> GetPersonList()
        {
            return DirectoryList;
        }
    }
}
