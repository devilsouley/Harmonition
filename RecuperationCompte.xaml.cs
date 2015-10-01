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
    /// Cette page sert à récupérer un compte existant en envoyant un courriel 
    /// </summary>
    public partial class RecuperationCompte : Window
    {
        /// <summary>
        /// Constructeur de la page récupération de compte
        /// </summary>
        public RecuperationCompte(string courriel)
        {
            InitializeComponent();
            txtMessage.Text = "Si l'adresse courriel existe dans notre base de\ndonnées, un message sera envoyé à l'adresse\ncourriel suivante pour vous permettre\nde réinitialisé votre mot de passe.\n\nMerci de cousulter votre messagerie:\n"+courriel;
        }

        /// <summary>
        /// Boutton pour réenvoyer un message courriel de récupération de compte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReenvoyerMessage(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Boutton pour fermer la page de récupération de compte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }        
    }
}
