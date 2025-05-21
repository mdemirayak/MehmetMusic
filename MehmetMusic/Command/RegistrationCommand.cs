using MehmetMusic.Stores;
using MehmetMusic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetMusic.Command
{
    class RegistrationCommand : CommandBase
    {
        private readonly NavigationStore _navgigationStore;
        private readonly RegistrationViewModel _registrationViewModel;
        public RegistrationCommand(NavigationStore navigationStore)
        {
            _navgigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            _navgigationStore.CurrentViewModel = new RegistrationViewModel(_navgigationStore);
        }
    }
}
