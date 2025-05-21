using MehmetMusic.Model;
using MehmetMusic.Stores;
using MehmetMusic.ViewModels;
using MehmetMusic.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetMusic.Command
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly LoginViewModel _loginViewModel;
        
      
        public LoginCommand(NavigationStore navigationStore, LoginViewModel loginViewModel)
        {
            _navigationStore = navigationStore;
            _loginViewModel = loginViewModel;
        }
        public override void Execute(object parameter)
        {
            Login login = new Login();
            if (login.Einloggen(_loginViewModel.Username, _loginViewModel.Password))
            {
                _navigationStore.CurrentViewModel = new MusicAppViewModel();
            }

        }
    }
}
