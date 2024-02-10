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
using WPF2_FokavinMMO.Models;

namespace WPF2_FokavinMMO.Pages
{
    /// <summary>
    /// Логика взаимодействия для InvetoryPage.xaml
    /// </summary>
    public partial class InvetoryPage : Page
    {
        public InvetoryPage()
        {
            InitializeComponent();
            DGInventory.ItemsSource = App.DB.Inventory.ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddInventoryPage(new Inventory()));
        }

        private void BRedactor_Click(object sender, RoutedEventArgs e)
        {
            var selectedInventory = DGInventory.SelectedItem as Inventory;
            if (selectedInventory == null)
            {
                MessageBox.Show("Выбрать предмет");
                return;
            }
            NavigationService.Navigate(new AddInventoryPage(selectedInventory));
        }

        private void BDeleted_Click(object sender, RoutedEventArgs e)
        {
            var deletedInventory = DGInventory.SelectedItem as Inventory;
            if (deletedInventory != null)
            {
                App.DB.Inventory.Remove(deletedInventory);
                App.DB.SaveChanges();
                DGInventory.ItemsSource = App.DB.Inventory.ToList();
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGInventory.ItemsSource = App.DB.Inventory.ToList();
        }
    }
}
