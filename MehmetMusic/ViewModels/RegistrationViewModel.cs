using MehmetMusic.Command;
using MehmetMusic.Model;
using MehmetMusic.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MehmetMusic.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        //private Registration rs = new Registration();

        public List <int> GeburtsTagList { get; set; } = new List<int>();
        public List<int> GeburtsMonatList { get; set; } = new List<int>();
        public List<int> GeburtsJahrList { get; set; } = new List<int>();


        private string _vorname;
        public string Vorname
        {
            get { return _vorname; }

            set
            {
                _vorname = value;
                OnPropertyChanged();
            }
        }

        private string _nachname;
        public string Nachname
        {
            get { return _nachname; }

            set
            {
                _nachname = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }

            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private int _geburstag;
        public int GeburtsTag
        {
            get { return _geburstag; }
            set
            {
                _geburstag = value;
                OnPropertyChanged();
            }
        }

        private int _geburtsmonat;
        public int GeburtsMonat
        {
            get { return _geburtsmonat; }
            set
            {
                _geburtsmonat = value;
                OnPropertyChanged();
            }
        }

        private int _geburtsjahr;
        public int GeburtsJahr
        {
            get { return _geburtsjahr; }
            set
            {
                _geburtsjahr = value;
                OnPropertyChanged();
            }
        }




        public void AddBirthComboBox()
        {
          for(int i = 1; i <= 31; i++) GeburtsTagList.Add(i);
          for(int i = 1; i <= 12; i++) GeburtsMonatList.Add(i);
          for (int i = 1920; i <= DateTime.Now.Year; i++) GeburtsJahrList.Add(i); 
        }

        public void SchaltJahrCheck()
        {
            GeburtsTagList.Add(+1);
        }




        public ICommand BackToLogin { get; }

        public RegistrationViewModel(NavigationStore navigationStore)
        {

            AddBirthComboBox();
            //SchaltJahrCheck();
            _navigationStore = navigationStore;
            
            BackToLogin = new BackToLoginCommand(_navigationStore);
        }
    }
}
