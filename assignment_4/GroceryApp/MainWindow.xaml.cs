using GroceryApp.Data;
using GroceryApp.Models;
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

namespace GroceryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DbInitializer.Initialize();
            LoadItems();
        }

        private void LoadItems()
        {
            using var db = new AppDbContext();
            ItemsDataGrid.ItemsSource = db.GroceryItems.ToList();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                !int.TryParse(QuantityTextBox.Text, out int qty) ||
                string.IsNullOrWhiteSpace(CategoryTextBox.Text))
            {
                MessageBox.Show("Please enter valid item details.", "Input Error");
                return;
            }

            using var db = new AppDbContext();
            db.GroceryItems.Add(new GroceryItem
            {
                Name = NameTextBox.Text.Trim(),
                Quantity = qty,
                Category = CategoryTextBox.Text.Trim()
            });

            db.SaveChanges();
            LoadItems();

            NameTextBox.Clear();
            QuantityTextBox.Clear();
            CategoryTextBox.Clear();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsDataGrid.SelectedItem is GroceryItem selectedItem)
            {
                using var db = new AppDbContext();
                var item = db.GroceryItems.Find(selectedItem.Id);
                if (item != null)
                {
                    db.GroceryItems.Remove(item);
                    db.SaveChanges();
                    LoadItems();
                }
            }
        }
    }
}