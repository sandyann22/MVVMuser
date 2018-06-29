using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class User

    {//CONSTRUCTEUR
        public string pFirstName { get; set; }// getters et setters
        public  string pLastName{ get; set; }
        public string pEmail { get; set; }
 
        public User(string aFirstName, string aLastName, string aEmail )// variables 
        {
            pFirstName = aFirstName;
            pLastName = aLastName;
            pEmail = aEmail;
        }
        //CREATION DE LA COLLECTION DE MESSAGE
        public ObservableCollection<User> Users { get; set; }
        public User() { }
    }
}
