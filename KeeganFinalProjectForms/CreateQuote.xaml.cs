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

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for CreateQuote.xaml
    /// </summary>
    public partial class CreateQuote : Window
    {
        public CreateQuote()
        {
            InitializeComponent();
        }

        private void btnCreateQuote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateReservation createreservation = new CreateReservation();
            createreservation.Show();
        }

        private void btnStartOver_Click(object sender, RoutedEventArgs e)
        {
            //Just clear and Reset Everything?
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainScreen Mainmenu = new MainScreen();
            Mainmenu.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
