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

namespace Harmonition
{
    /// <summary>
    /// Page de connexion d'un membre.
    /// </summary>
    public partial class Connexion : Window
    {
        /// <summary>
        /// Constructeur de la page connexion
        /// </summary>
        public Connexion()
        {
            InitializeComponent();
        }

        #region MouseOverLink
        /// <summary>
        /// Permet de mettre en surbrillance le bouton hyperlink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecupererCompte_MouseEnter(object sender, MouseEventArgs e)
        {
            btnRecupererCompte.Foreground = Brushes.DarkBlue;
        }

        /// <summary>
        /// Permet d'enlever la surbrillance de l'hyperlien lorsque le curseur quitte le boutton. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecupererCompte_MouseLeave(object sender, MouseEventArgs e)
        {
            btnRecupererCompte.Foreground = Brushes.SteelBlue;
        }
        #endregion
        #region hintTextPassword
        /// <summary>
        /// Permet de retirer l'indice sur le champ de mot de passe pour indiquer que ce champ est un mot de passe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "**********")
            {
                txtPassword.Password = "";
                txtPassword.Foreground = Brushes.Black;
            }
        }

        /// <summary>
        /// Permet de mettre l'indice sur le champ de mot de passe pour indiquer que ce champ est un mot de passe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "")
            {
                txtPassword.Password = "**********";
                txtPassword.Foreground = Brushes.LightGray;
            }
        }
        #endregion

        /// <summary>
        /// Boutton permettant d'accéder à la page de création d'un membre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewUser_Click(object sender, RoutedEventArgs e)
        {
            //TODO Ouvre la page de création de compte.
            this.Close();
        }

        /// <summary>
        /// Boutton permettant d'accéder à la page de récupération d'un compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecupererCompte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Recuperation en cours");
        }

        /// <summary>
        /// Boutton permettant de valider le membre et de retourner à la page principal avec toutes les fonctionnalités du membre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            //TODO Valider le compte (USER and PASSWORD) dans la base de donnée.
            //TODO Valider si doit maintenir la connection.
        }

        /// <summary>
        /// Boutton pour fermer la page de connexion sans se connecter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
