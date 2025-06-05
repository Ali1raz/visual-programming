using assignment_4.Seeder;
using System.Configuration;
using System.Data;
using System.Windows;

namespace assignment_4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DbInitializer.Initialize();
        }
    }

}
