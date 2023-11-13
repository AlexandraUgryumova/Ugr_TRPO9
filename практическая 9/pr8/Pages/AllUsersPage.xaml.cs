using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using pr8.Classes;

namespace pr8.Pages
{
    /// <summary>
    /// Логика взаимодействия для AllUsersPage.xaml
    /// </summary>
    public partial class AllUsersPage : Page
    {
        public ObservableCollection<User> users = new ObservableCollection<User>();
        public User selectedUser { get; set; }
        
        public AllUsersPage()
        {
            InitializeComponent();

            users.Add(new User("Masha","Admin", DateTime.Now));
            users.Add(new User("Petya", "User", DateTime.Now));
            users.Add(new User("Vasya", "User", DateTime.Now));
            DataContext = this;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(selectedUser != null)
            {
                users.Remove(selectedUser);
            }
        }
    }
}
