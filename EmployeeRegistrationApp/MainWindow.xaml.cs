using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeRegistrationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string email = txtEmail.Text.Trim();
            string department = (cbDepartment.SelectedItem as ComboBoxItem)?.Content.ToString();

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(name))
                errors.AppendLine("Name is required.");

            if (!int.TryParse(ageText, out int age) || age < 18 || age > 60)
                errors.AppendLine("Age must be a number between 18 and 60.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errors.AppendLine("Invalid email format.");

            if (string.IsNullOrEmpty(department))
                errors.AppendLine("Please select a department.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}