using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using MVVM.ViewModels;

namespace MVVM.ViewModels
{
    public class UserViewModel : BaseViewModel//LIEN VERS BASEVIEWMODELE
    {
        //CONSTRUCTEUR ET METHODE POUR CREER NOUVEL OBJET COLLECTION
        public ObservableCollection<User> pUsers { get; set; }
        //Collection de type User Nommee pUsers avec getter et setter
        public UserViewModel()
        {
            pUsers = new ObservableCollection<User>();
            //instanciation de la nouvelle collection
        }
        //METHODE POUR CREER NOUVEL OBJET UTILISATEUR
        public void createUser(string aFisrtName, string aLastName, string aEmail)
        { //on reprend les propriétés de la classe User

            User wUser = new User(aFisrtName, aLastName, aEmail);
            //instanciation du nouvel utilisateur

            pUsers.Add(wUser);//ajout du nouvel utilisateur
        }
    }
}