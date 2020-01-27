using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace TextEdit_EditNonEditableTemplate {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Employee> Data {
            get;
            set;
        }
        public ViewModel()
        {
            Data = new ObservableCollection<Employee>();
            Data.Add(new Employee { Name = "Steven", CardColor = "Red" });
            Data.Add(new Employee { Name = "Mary", CardColor = "Green" });
            Data.Add(new Employee { Name = "John", CardColor = "Blue" });
            Data.Add(new Employee { Name = "Claudia", CardColor = "Red" });
        }
    }
    public class Employee {
        public string Name { get; set; }
        public string CardColor { get; set; }
    }
}