using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class MessageViewModel : BaseViewModel
    {
        public ObservableCollection<Message> PMessages { get; set; }

        public MessageViewModel()
        {

            PMessages = new ObservableCollection<Message>();
        }

        public void CreateMessage(string mFirstName, string mLastName, string mMessage)
        {
            Message wMessage = new Message( mFirstName,  mLastName, mMessage);
            PMessages.Add(wMessage);
        }

    }
}
