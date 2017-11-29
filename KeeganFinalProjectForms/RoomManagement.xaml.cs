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
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        List<Room> roomList;
        public RoomManagement()
        {
            InitializeComponent();

            roomList = new List<Room>();
            dtgRoomMgmt.ItemsSource = roomList;
        }
        #region JSON

        private void btnImportJson_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files | *.json";

            if (openFileDialog.ShowDialog() == true)
                string strFilePath = openFileDialog.FileName.ToString();

            try
            {
                StreamReader reader = new StreamReader(strFilePath);
                string jsonData = reader.ReadToEnd();
                reader.Close();

                roomList = JsonConvert.DeserializeObject<List<Room>>(jsonData);

                dtgRoomMgmt.ItemsSource = roomList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in import process: " + ex.Message);
            }

            dtgRoomMgmt.Items.Refresh();
        }

        private void btnExportJson_Click(object sender, RoutedEventArgs e)
        {
            string strFilePath = GetFilePath("json", true);

            try
            {
                StreamWriter writer = new StreamWriter(strFilePath, false);
                string jsonData = JsonConvert.SerializeObject(roomList);
                writer.Write(jsonData);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in export process: " + ex.Message);
            }

            MessageBox.Show("Export completed!" + Environment.NewLine + "File Created: " + strFilePath);
        }

        #endregion
    }
}
