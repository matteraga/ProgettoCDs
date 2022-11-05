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

namespace ProgettoCDs
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Brano brano1;
        CD cd1;

        private void btnCreaBrano_Click(object sender, RoutedEventArgs e)
        {
            brano1 = new Brano(txtTitolo.Text,txtAutore.Text,double.Parse(txtDurata.Text));
        }

        private void btnCreaCD_Click(object sender, RoutedEventArgs e)
        {
            cd1 = new CD(txtTitoloCD.Text, txtAutoreCD.Text);
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(brano1.toString());
        }

        private void btnCmpDurata_Click(object sender, RoutedEventArgs e)
        {
            brano1.shortSong(double.Parse(txtDurata.Text));
        }

        private void btnStampaTitoli_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cd1.ToString());
        }

        private void btnReturnDurata_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cd1.durata().ToString());
        }
    }
}
