using mid_proj.Models;
using mid_proj.Services;
using mid_proj.Views;
using System.Windows;
using System.Windows.Input;

namespace 
public class LoginViewModel : ViewModelBase
{
    private string _email;
    private string _password;
    private readonly MockUserService _userService = new MockUserService();

    public string Email
    {
        get => _email;
        set { _email = value; OnPropertyChanged(); }
    }

    public string Password
    {
        get => _password;
        set { _password = value; OnPropertyChanged(); }
    }

    public ICommand LoginCommand { get; }
    public ICommand RegisterCommand { get; }

    public LoginViewModel()
    {
        LoginCommand = new RelayCommand(_ => Login());
        RegisterCommand = new RelayCommand(_ => Register());
    }

    private void Login()
    {
        var user = _userService.Authenticate(Email, Password);
        if (user != null)
        {
            // Navigate to Dashboard
            var dashboardView = new DashboardView();
            dashboardView.Show();
            Application.Current.Windows[0]?.Close();
        }
        else
        {
            MessageBox.Show("Invalid credentials!");
        }
    }

    private void Register()
    {
        var user = new User { Email = Email, Password = Password, Role = "Regular" };
        if (_userService.Register(user))
            MessageBox.Show("Registration successful!");
        else
            MessageBox.Show("Email already exists!");
    }
}