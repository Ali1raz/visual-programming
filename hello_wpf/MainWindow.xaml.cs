using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hello_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            DataContext = this;
        }

        // act 3:
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

        // task 1:

        private void LoadData()
        {
            Students = new ObservableCollection<Student>
            {
                new Student { Name = "Alice", Age = 20, GPA = 3.8 },
                new Student { Name = "Bob", Age = 22, GPA = 3.5 },
                new Student { Name = "Charlie", Age = 21, GPA = 3.9 }
            };
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }
}
