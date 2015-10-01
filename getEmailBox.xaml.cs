using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// La fenêtre getEmailBox sert à obtenir l'adresse courriel du compte perdu de l'utilisateur afin qu'il puisse le récupérer à partir de la fenêtre Récupération de compte. 
    /// </summary>
    public partial class getEmailBox : Window
    {
        /// <summary>
        /// Constructeur de getEmailBox.
        /// </summary>
        public getEmailBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sert à valider si l'adresse email saisie par l'utilisateur est valide.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        private bool estUneAdresseEmail(string emailAddress)
        {
            try
            {
                //Si l'adresse e-mail n'a pas le bon format dans la class MailAddress, il retournera automatiquement une erreur et sera attrapé par le catch.
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Appel la validation du courriel et affiche une surbrillance sur l'erreur.
        /// Si la validation est bonne, elle ferme la page courante et ouvre la fenêtre Récupération de compte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if(estUneAdresseEmail(txtCourriel.Text))
            {
                RecuperationCompte pageRecuperationCompte = new RecuperationCompte(txtCourriel.Text);
                pageRecuperationCompte.Show();
                this.Close();
            }
            txtCourriel.Background = Brushes.LightSalmon;
            txtCourriel.BorderBrush = Brushes.Red;
            txtCourriel.ToolTip = "L'adresse courriel n'est pas valide!";
        }

        /// <summary>
        /// Enlêve la surbrillance de l'erreur lorsque l'utilisateur a le focus sur le champ de courriel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCourriel_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCourriel.Background = Brushes.White;
        }
    }
}
