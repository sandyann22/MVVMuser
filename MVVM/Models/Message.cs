using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Message
    {
        public string PFirstName { get; set; }
        public string PLastName { get; set; }
        public string PMessage { get; set; }

        public ObservableCollection<Message> Messages { get; set; }
        public Message() { }

        public Message(string mPFirstName, string mPLastName, string mPMessage)
        {
            PFirstName = mPFirstName;
            PLastName = mPLastName;
            PMessage = mPMessage;
        }
    }
}
