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

namespace Harmonition___Version_Julie
{
    /// <summary>
    /// Logique d'interaction pour CreationDeCompte.xaml
    /// </summary>
    public partial class CreationDeCompte : Window
    {
        public CreationDeCompte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Premet de savoir si l'utilisateur utilise a-z ou A-Z 
        /// </summary>
        /// <param name="champ">champ à valider</param>
        /// <returns>Retourne vrai si le champ contient des lettres uniquement</returns>
        private bool utiliseAlphabet(TextBox champ)
        {
            int nbTirets = 0;
            for (int car = 0; car < champ.Text.Length; car++)
            {
                if (champ.Text[car] != '-')
                {
                    if (!((champ.Text[car] >= 97 && champ.Text[car] <= 122) || (champ.Text[car] >= 65 && champ.Text[car] <= 90)))
                    {
                        return false;
                    }
                }
                else
                {
                    nbTirets++;

                    // Si l'utilisateur utilise plus de 2 tirets, le champ n'est pas valide
                    if (nbTirets > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Valide le champ Prénom et affiche s'il est valide ou pas avec la raison si non valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerPrenom(object sender, KeyEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            StringBuilder resultat = new StringBuilder();

            // Si le prénom est vide ou qu'il dépasse le nombre de caractère maximal, il n'est pas valide.
            // TODO: rajouter la longueur maximum
            if (temp.Text.Length == 0)
            {
                resultat.AppendLine("Invalide: Le champ Prénom est vide.");
            }
            else if (temp.Text.Length > 50)
            {
                resultat.AppendLine("Invalide: Le champ Prénom dépasse le nombre de caractères maximal(50).");
            }
            else if (!utiliseAlphabet(temp))
            {
                resultat.AppendLine("Invalide: Le champ Prénom contient des caractères autre que l'alphabet.");               
            }
            // On écrit l'erreur dans la zone de droite.
            txtValidationChamps.Text = resultat.ToString();
        }

        /// <summary>
        /// Valide le champ Nom et affiche s'il est valide ou pas avec la raison si non valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerNom(object sender, KeyEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            StringBuilder resultat = new StringBuilder();
            
            // Si le nom est vide ou qu'il dépasse le nombre de caractères maximal, il n'est pas valide.
            // TODO: rajouter la longueur maximum
            if (temp.Text.Length == 0)
            {
                resultat.AppendLine("Invalide: Le champ Nom est vide.");
            }
            else if (temp.Text.Length > 50)
            {
                resultat.AppendLine("Invalide: Le champ Nom dépasse le nombre de caractères maximal(50).");
            }
            else if (!utiliseAlphabet(temp))
            {
                resultat.AppendLine("Invalide: Le champ Prénom contient des caractères autre que l'alphabet.");            
            }

            // On écrit l'erreur dans la zone de droite.
            txtValidationChamps.Text = resultat.ToString();
        }

        /// <summary>
        /// Valide le champ Courriel et affiche s'il est valide ou pas avec la raison si non valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerCourriel(object sender, KeyEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            StringBuilder resultat = new StringBuilder();
            // Exemple minimal: a@a.a

            // Pour que l'adresse courriel soit complète, il faut un minimum de 5 caractères
            if (temp.Text.Length < 5)
            {
                resultat.AppendLine("Invalide : L'adresse courriel est incomplète.");
            }
            else if(temp.Text.Length > 60)
            {
                resultat.AppendLine("Invalide : L'adresse courriel dépasse le nombre de caractères maximal.");
            }
            else
            {             
                for (int carac = 0; carac < temp.Text.Length; carac++)
                {
                    // Si l'arrobase est au debut ou à la fin, l'adresse courriel est invalide
                    if ((carac == 0 || carac > (temp.Text.Length - 3)) && temp.Text[0] == '@')
                    {
                        resultat.AppendLine("Invalide : Il manque le nom de votre courriel.");
                    }
                    // Si le point est au debut ou le dernier caractère, l'adresse courriel est invalide
                    else if ((carac == 0 || carac > (temp.Text.Length - 1)) && temp.Text[0] == '.')
                    {
                        resultat.AppendLine("Invalide : Il manque le nom de domaine de votre courriel.");
                    }
                    // Si l'adresse courriel ne contient pas d'arrobase ou de point, l'adresse courriel est incomplète
                    else if (!temp.Text.Contains('@') || !temp.Text.Contains('.'))
                    {
                        resultat.AppendLine("Invalide : L'adresse courriel est incomplète.");
                    }
                }
            }

            // On écrit l'erreur dans la zone de droite.
            txtValidationChamps.Text = resultat.ToString();
            
        }
    }
}
