using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVM.ViewModels;

namespace MVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour MessageView.xaml
    /// </summary>
    public partial class MessageView : Page
    { 
    public MessageViewModel _messageViewModel { get; set; }//constructeur 
    
        public MessageView()
        {
            InitializeComponent();
        _messageViewModel =new MessageViewModel();
        this.DataContext = _messageViewModel;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        _messageViewModel.CreateMessage(txBoxFirstName.Text, txBoxLastName.Text, ZoneMessage.Text);
    }
    }
}
