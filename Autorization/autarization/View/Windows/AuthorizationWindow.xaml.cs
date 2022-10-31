using Autorization.Core;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();


        }
        private void btnSingin_Click(object sender, RoutedEventArgs e)
        {
            if (UserLogic.Validate(tbLogin.Text, tbPassword.Password))
            {
                new AdminWindow().Show();
                Close();
            }
            else MessageBox.Show("Ошибочка", "Введите правильный логин или пароль!",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
