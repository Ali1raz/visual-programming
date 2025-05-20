using mid_proj.ViewModels; // Updated namespace
using System;
using System.Windows;

namespace mid_proj.Views // Updated namespace
{
    public partial class RegisterWindow : Window
    {
        private readonly RegisterViewModel _viewModel;

        public RegisterWindow()
        {
            InitializeComponent();
            _viewModel = DataContext as RegisterViewModel ?? throw new InvalidOperationException("DataContext must be RegisterViewModel");

            _viewModel.RegistrationSuccess += ViewModel_RegistrationSuccess;
            _viewModel.NavigateLoginRequested += ViewModel_NavigateLoginRequested;
        }

        private void ViewModel_RegistrationSuccess(object? sender, EventArgs e)
        {
            MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigateToLogin();
        }

        private void ViewModel_NavigateLoginRequested(object? sender, EventArgs e) => NavigateToLogin();

        private void NavigateToLogin()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            _viewModel.RegistrationSuccess -= ViewModel_RegistrationSuccess;
            _viewModel.NavigateLoginRequested -= ViewModel_NavigateLoginRequested;
            base.OnClosed(e);
        }
    }
}