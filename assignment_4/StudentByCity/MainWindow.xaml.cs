using assignment_4.Data;
using assignment_4.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assignment_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAllStudents();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string cityInput = CityTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cityInput))
            {
                MessageBox.Show("Please enter a city name.", "Input Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            using var db = new AppDbContext();

            var studentsInCity = db.Students
                .Where(s => s.City.ToLower().Contains(cityInput.ToLower()))
                .ToList();

            if (studentsInCity.Any())
            {
                StudentsDataGrid.ItemsSource = studentsInCity;
            }
            else
            {
                MessageBox.Show($"No students found in city: {cityInput}", "No Results", MessageBoxButton.OK, MessageBoxImage.Information);
                StudentsDataGrid.ItemsSource = null;
            }
        }

        private void LoadAllStudents()
        {
            using var db = new AppDbContext();
            var allStudents = db.Students.ToList();
            StudentsDataGrid.ItemsSource = allStudents;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            CityTextBox.Text = "";
            LoadAllStudents();
        }

        private void CityTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CityTextBox.Text == "Enter city name...")
            {
                CityTextBox.Text = "";
                CityTextBox.Foreground = Brushes.Black;
            }
        }

        private void CityTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                CityTextBox.Text = "Enter city name...";
                CityTextBox.Foreground = Brushes.Gray;
            }
        }

    }
}
