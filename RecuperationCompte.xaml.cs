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

namespace Harmonition
{
    /// <summary>
    /// Logique d'interaction pour RecuperationCompte.xaml
    /// </summary>
    public partial class RecuperationCompte : Window
    {
        /// <summary>
        /// Constructeur de la page récupération de compte
        /// </summary>
        public RecuperationCompte()
        {
            InitializeComponent();
            txtMessage.Text = "Un message a été envoyé à l'adresse courriel\nsuivante pour vous permettre de réinitialisé\nvotre mot de passe.\n\ncourriel: ";
        }

        /// <summary>
        /// Boutton pour fermer la page de récupération de compte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
