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

            if (person!=null)
            {
                DirectoryList.Add(person);
                ShowMessage message = new ShowMessage(true);
                return message.Message;
            }
            else
            {
                ShowMessage message = new ShowMessage(false);
                return message.Message;
            }

        }


        public override string DeletePerson(string name)
        {
            Person person = DirectoryList.SingleOrDefault(x => x.Name == name);
            if (person != null)
            {
                DirectoryList.Remove(person);
                ShowMessage message = new ShowMessage(true);
                return message.Message;
            }
            else
            {
                ShowMessage message = new ShowMessage(false);
                return message.Message;
            }
        }

        public override List<Person> GetPersonList()
        {
            return DirectoryList;
        }
    }
}
