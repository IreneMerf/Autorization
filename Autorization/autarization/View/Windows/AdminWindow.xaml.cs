using autarization.Core;
using autarization.View.Pages;
using Autorization.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace autarization.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

        }

        private void btnLoadUsers_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
        }
        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = UserParser.ParseFile("users2.txt").ToList();

            var reapeatedUser = users.FirstOrDefault(u => u.FirstName == tbFirstName.Text &&
            u.MiddleName == tbMiddleName.Text && u.LastName == tbLastName.Text);

            if (reapeatedUser != null)
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
            
        }

        private void ClearTextFields()
        {
            tbID.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbMiddleName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbDateOfBirth.Text = string.Empty;
            tbSalary.Text = string.Empty;
        }
    }
}
