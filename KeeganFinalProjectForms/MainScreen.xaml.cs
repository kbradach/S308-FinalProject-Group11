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
using System.IO;

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            //test change
        }
        private void btnNewReservation_Click(object sender, RoutedEventArgs e) //
        {
            CreateQuote quoteWindow = new CreateQuote();
            quoteWindow.Show();
            this.Close();
        }
        public void btnNewReservation_Click(object sender, RoutedEventArgs e) //
        {
            CreateQuote quoteWindow = new CreateQuote();
            quoteWindow.Show();
            this.Close();
        }
        private void btnRoomManagement_Click(object sender, RoutedEventArgs e) //
        {
            RoomManagement mgmtWindow = new RoomManagement();
            mgmtWindow.Show();
            this.Close();
        }
        private void btnReservationReport_Click(object sender, RoutedEventArgs e) //
        {
            ReservationReport reportWindow = new ReservationReport();
            reportWindow.Show();
            this.Close();
        }
    }
}
