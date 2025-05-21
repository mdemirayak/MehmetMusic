using MehmetMusic.Command;
using MehmetMusic.Model;
using MehmetMusic.Stores;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MehmetMusic.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        
        private readonly NavigationStore _navigationStore;

        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
               _username = value;
                OnPropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value; 
                OnPropertyChanged();
            }
        }

       
        public ICommand ShowMusicAppCommand { get; } 
        public ICommand RegistrationCommand { get; }

       


        public LoginViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            //ShowMusicAppCommand = new LoginCommand(_navigationStore,this);
            ShowMusicAppCommand = new LoginCommand(_navigationStore,this);
            RegistrationCommand = new RegistrationCommand(_navigationStore);
            
        }

        
       

    }
}
