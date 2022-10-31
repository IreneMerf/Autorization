using autarization.Command;
using autarization.Core;
using Autorization.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace autarization.ViewModel
{
    class UsersViewModel : BaseViewModel
    {
        
            private ObservableCollection<User> _users;
            private User _selectedUser;

            public ObservableCollection<User> Users { get => _users; set => SetProperty(ref _users, value); }

            public User SelectedUser { get => _selectedUser; set => SetProperty(ref _selectedUser, value); }

            public ICommand ShowUserCommand { get; private set; }

            public UsersViewModel()
            {
                ShowUserCommand = new DelegateCommand(ShowUser);

                Users = new ObservableCollection<User>(UserParser.ParseFile("users2.txt"));
            }
            private void ShowUser(object paremeter)
            {
                MessageBox.Show(SelectedUser.BornDate.ToString());
            }


        }
    }

