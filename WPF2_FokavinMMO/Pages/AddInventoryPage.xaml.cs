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
    
    public partial class AddInventoryPage : Page
    {
        Inventory contextinventory;
        public AddInventoryPage(Inventory inventory)
        {
            InitializeComponent();
            CBRarity.ItemsSource = App.DB.Rarity.ToList();
            CBCharacterClass.ItemsSource = App.DB.CharacterClass.ToList();
            contextinventory = inventory;
            DataContext = contextinventory;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextinventory.id == 0)
                App.DB.Inventory.Add(contextinventory);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
