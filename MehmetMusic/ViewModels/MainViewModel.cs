using MehmetMusic.Command;
using MehmetMusic.Stores;
using MehmetMusic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MehmetMusic.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
       

        private readonly NavigationStore _navigationStore;
        public BaseViewModel Content => _navigationStore.CurrentViewModel;


        public MainViewModel(NavigationStore navigationStore)
        {
            
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewChanged;
        }

        private void OnCurrentViewChanged()
        {
            OnPropertyChanged(nameof(Content));
        }
    }
}
