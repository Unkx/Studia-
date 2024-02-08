using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class DevicesWindow : Window
    {
        private DeviceService deviceService = new DeviceService();
        public ObservableCollection<Device> Devices { get; set; } = new ObservableCollection<Device>();

        public DevicesWindow()
        {
            InitializeComponent();
            LoadDevices();
            DataContext = this;
        }

        private void LoadDevices()
        {
            Devices.Clear();
            var deviceList = deviceService.GetDevices();
            foreach (var device in deviceList)
            {
                Devices.Add(device);
            }
        }

        private void AddDeviceButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle adding a new device, use deviceService.AddDevice()

            // Get values from textboxes
            string deviceName = txtDeviceName.Text;
            string deviceDescription = txtDeviceDescription.Text;
            int ramSize = Convert.ToInt32(txtRamSize.Text);
            int discSize = Convert.ToInt32(txtDiscSize.Text);
            string os = txtOS.Text;
            string broken = txtBroken.Text;

            // Add the device to the database
            deviceService.AddDevice(new Device
            {
                Name = deviceName,
                Description = deviceDescription,
                RamSize = ramSize,
                DiscSize = discSize,
                OS = os,
                Broken = broken
            });

            // Refresh the UI
            LoadDevices();

            // Clear the textboxes
            txtDeviceName.Clear();
            txtDeviceDescription.Clear();
            txtRamSize.Clear();
            txtDiscSize.Clear();
            txtOS.Clear();
            txtBroken.Clear();
        }

        private void RemoveDeviceButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if any item is selected in the DataGrid
            if (devicesDataGrid.SelectedItem != null && devicesDataGrid.SelectedItem is Device selectedDevice)
            {
                // Get the ID of the selected device
                int deviceId = selectedDevice.Id;

                // Call the RemoveDevice method in your DeviceService
                deviceService.RemoveDevice(deviceId);

                // Refresh the UI
                LoadDevices();
            }
            else
            {
                MessageBox.Show("Please select a device to remove.");
            }
        }
        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            Close();
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
