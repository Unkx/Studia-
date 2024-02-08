using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private DeviceService deviceService = new DeviceService();
        public ObservableCollection<Device> Devices { get; set; } = new ObservableCollection<Device>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            DevicesWindow devicesWindow = new DevicesWindow();
            devicesWindow.Show();
            Close();
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            Close();
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
