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

namespace progettoCD
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int mintemp=5;
        Brano p;
        int tot = 0;
        string lista = "Temi del cidi ";
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txttitolo.Text;
            lista = lista + titolo;
            string au = txtnome.Text;
            int dura = int.Parse(txtdurata.Text);
            tot = tot + dura;
            p = new Brano(titolo, au, dura);
            bool stato = false;
            stato = p.ShortSong(mintemp);
            if (stato != true)
            {
                MessageBox.Show("Tempo inserito superiore a quello concesso");
            }
            else
            {
            lstbrani.Items.Add("titolo " + titolo + " ," + " autore " + au + " , durata  " + dura);
            

               
            }
          
            
        }
       

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            
            lstcd.Items.Add("The CD " + txtcd.Text + " created by " + txtnomecreatore.Text + " sponsored by " + txtetichetta.Text +"|| durata totale disco "+ tot );
           
        }

        private void lstcd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             if(lstcd.SelectedItem!=null)
            {
                btnInserisci.IsEnabled = true;

            }
        }

        private void btnlista_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("" + lista);
        }
    }
}
