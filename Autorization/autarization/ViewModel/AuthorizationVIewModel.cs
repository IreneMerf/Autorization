using autarization.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace autarization.ViewModel
{
   public class AuthorizationVIewModel : BaseViewModel
    {
        private string _login;
        private string _password;


        public  string Login { get => _login; set => SetProperty(ref _login, value);  }

        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public ICommand SignInCommand { get; private set; }
        public AuthorizationVIewModel()
        {
            SignInCommand = new DelegateCommand(SignIn);
        }

        private void SignIn(object parameter)
        {
            MessageBox.Show(parameter.ToString());
        }
    }
}
