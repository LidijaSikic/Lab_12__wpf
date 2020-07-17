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

namespace Lab_12__wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Izlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Pregled_Click(object sender, RoutedEventArgs e)
        {
            ProzorPregleda prozor = new ProzorPregleda();
            TextRange text = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
           
            prozor.TextBlock.Text = text.Text;
            prozor.ShowDialog();

        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
            text.Text = "";
        }

        private void btnPonovi_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
            text.Text += text.Text;
        }
    }
}
