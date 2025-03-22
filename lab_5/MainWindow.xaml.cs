using System;
using System.Collections.Generic;
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

namespace lab_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password; // PasswordBox doesn't expose plain text for security reasons
            string role = lstRole.SelectedItem != null ? (lstRole.SelectedItem as ListBoxItem).Content.ToString() : "Not Selected";
            string degree = lstDegree.SelectedItem != null ? (lstDegree.SelectedItem as ListBoxItem).Content.ToString() : "Not Selected";

            string message = $"Username: {username}\nPassword: {password}\nRole: {role}\nDegree: {degree}";
            MessageBox.Show(message, "User Details");
        }
    }

}
