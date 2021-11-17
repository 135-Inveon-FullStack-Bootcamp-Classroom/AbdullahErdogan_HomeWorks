using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class ShowMessage
    {
        private string _message;
        public string Message { get => _message; set => _message = value; }
        public ShowMessage(bool isOk)
        {
            if (isOk)
            {
                Message = "successful";
            }
            else
            {
                Message = "Failed";
            }
        }
    }
}
