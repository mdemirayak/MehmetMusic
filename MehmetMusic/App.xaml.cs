using MehmetMusic.Stores;
using MehmetMusic.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows;

namespace MehmetMusic
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {

        private readonly NavigationStore _navigationStore;

        /*protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel();
            MainWindow main = new MainWindow();
            main.DataContext = new MainViewModel(_navigationStore);
            main.Show();
            base.OnStartup(e);
        }*/

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);

            MainWindow main = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            main.Show();
            base.OnStartup(e);
        }

        public App()
        {
            _navigationStore = new NavigationStore();
        }
    }
}
