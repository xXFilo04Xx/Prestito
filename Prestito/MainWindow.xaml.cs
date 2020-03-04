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

namespace Prestito
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

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            string nascita;
            string cognome = txtcognome.Text;
            string nome = txtnome.Text; 
            if (txtm.IsChecked == true)
            {
                nascita = "è nata";
            }
            else
            {
                nascita = "è nato";
                txtf.IsChecked = false;
            }
            DatePicker DataTime = new DatePicker();
            double percentuale = double.Parse(txtpercentuale.Text);
            double importo = double.Parse(txtimporto.Text);
            double rate = double.Parse(txtrate.Text);
            double restituire = importo * percentuale / 100;
            txtimprestituire.Text = restituire.ToString();
            double importorate = restituire / rate;
            txtdata1.Text = importorate.ToString();
            lblrisultato.Content = $"{nome}{cognome},residente in {txtcombo} {nascita} il {txtdata},prestito di {txtimporto} ad un tasso del {txtpercentuale} da restituire in {txtrate} rate da {txtdata1} ciascuna per un totale di {txtimprestituire} ";

        }

        private void btnnuovo_Click(object sender, RoutedEventArgs e)
        {
            txtcognome.Clear();
            txtcombo.SelectedItem = null;
            txtdata.SelectedDate = null;
            txtf.IsChecked = null;
            txtm.IsChecked = null;
            lblrisultato.Content = null;
            txtnome.Clear();
            txtimporto.Clear();
            txtimprestituire.Text = null;
            txtm.IsChecked = null;
            txtpercentuale.Clear();
            txtrate.Clear();
            txtdata1.Text = null;





        }
    }
}
