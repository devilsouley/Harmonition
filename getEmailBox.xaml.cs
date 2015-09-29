using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Harmonition
{
    /// <summary>
    /// Logique d'interaction pour getEmailBox.xaml
    /// </summary>
    public partial class getEmailBox : Window
    {
        public getEmailBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //La validation proviens de http://www.regular-expressions.info/email.html
            if(Regex.IsMatch(txtCourriel.Text, @"\^[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}$\"))
            {
                RecuperationCompte pageRecuperationCompte = new RecuperationCompte(txtCourriel.Text);
                pageRecuperationCompte.Show();
                this.Close();
            }
            txtCourriel.Background = Brushes.LightSalmon;
            txtCourriel.BorderBrush = Brushes.Red;
            txtCourriel.ToolTip = "L'adresse courriel n'est pas valide!";
        }

        private void txtCourriel_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCourriel.Background = Brushes.White;
        }
    }
}
