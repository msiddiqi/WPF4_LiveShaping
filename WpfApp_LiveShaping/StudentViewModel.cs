using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_LiveShaping
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.Equals(_firstName, value))
                {
                    return;
                }

                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.Equals(_lastName, value))
                {
                    return;
                }

                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
