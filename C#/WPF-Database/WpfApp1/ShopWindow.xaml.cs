using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class ShopWindow : Window
    {
        private ShopService shopService = new ShopService();
        public ObservableCollection<Shop> Shops { get; set; } = new ObservableCollection<Shop>();

        public ShopWindow()
        {
            InitializeComponent();
            LoadShops();
            DataContext = this;
        }

        private void LoadShops()
        {
            Shops.Clear();
            var shopList = shopService.GetShops();
            foreach (var shop in shopList)
            {
                Shops.Add(shop);
            }
        }

        private void AddShopButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle adding a new shop, use shopService.AddShop()

            // Get values from textboxes
            string shopName = txtShopName.Text;
            string shopDescription = txtShopDescription.Text;
            int ramSize = Convert.ToInt32(txtRamSize.Text);
            int discSize = Convert.ToInt32(txtDiscSize.Text);
            string os = txtOS.Text;
            string shopColor = txtShopColor.Text;
            string shopPrice = txtShopPrice.Text;
            int shopYearOfProduction = Convert.ToInt32(txtShopYearOfProduction.Text);

            // Add the shop to the database
            shopService.AddShop(new Shop
            {
                Name = shopName,
                Description = shopDescription,
                RamSize = ramSize,
                DiscSize = discSize,
                OS = os,
                Color = shopColor,
                Price = shopPrice,
                YearOfProduction = shopYearOfProduction
            });

            // Refresh the UI
            LoadShops();

            // Clear the textboxes
            txtShopName.Clear();
            txtShopDescription.Clear();
            txtRamSize.Clear();
            txtDiscSize.Clear();
            txtOS.Clear();
            txtShopColor.Clear();
            txtShopPrice.Clear();
            txtShopYearOfProduction.Clear();
        }

        private void RemoveShopButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if any item is selected in the DataGrid
            if (shopsDataGrid.SelectedItem != null && shopsDataGrid.SelectedItem is Shop selectedShop)
            {
                // Get the ID of the selected shop
                int shopId = selectedShop.Id;

                // Call the RemoveShop method in your ShopService
                shopService.RemoveShop(shopId);

                // Refresh the UI
                LoadShops();
            }
            else
            {
                MessageBox.Show("Please select a shop to remove.");
            }
        }
        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            DevicesWindow devicesWindow = new DevicesWindow();
            devicesWindow.Show();
            Close();
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
