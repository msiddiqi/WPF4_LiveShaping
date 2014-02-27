using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_LiveShaping
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Students = new ObservableCollection<StudentViewModel>();
            Students.Add(new StudentViewModel { FirstName = "Muhammad", LastName = "Siddiqi" });
            Students.Add(new StudentViewModel { FirstName = "Kate", LastName = "Hansen" });
            Students.Add(new StudentViewModel { FirstName = "Vladimir", LastName = "Khan" });
            
        }

        public ObservableCollection<StudentViewModel> Students { get; private set; }
    }
}
