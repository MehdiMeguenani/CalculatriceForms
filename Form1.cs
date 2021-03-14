using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Calculatrice;

namespace Calculatrice_Simplfifié
{
    /*Classe Calcultrice 
     * Auteur : Mehdi Meguenani
     * Date de création : 22 janvier 2021
     * Une calculatrice qui permet des calcul simple tel que Addition,Soustraction, Multiplication, Division. On utilise la classe Projet_Calculatrice 
     * */
    /// <summary>
    /// Calculatrice Widndows Forms 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1,n2,resultat;
        

        private void TBXNb1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void TBXNb2_TextChanged(object sender, EventArgs e)
        {

            
        }
        //Ce bouton va permettre de faire une addition en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une opération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddition_Click(object sender, EventArgs e)
        {
            double.TryParse(TBXNb1.Text, out n1);
            double.TryParse(TBXNb2.Text, out n2);
            resultat = Calculatrice.Addition(n1, n2);
            LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat);
        }
        //Ce bouton va permettre de faire une Multiplication en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une multiplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNMulti_Click(object sender, EventArgs e)
        {
            double.TryParse(TBXNb1.Text, out n1);
            double.TryParse(TBXNb2.Text, out n2);
            resultat = Calculatrice.Multiplication(n1, n2);
            LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat);
        }
        //Ce bouton va permettre de faire une Soustraction en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une  Soustraction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSoustraction_Click(object sender, EventArgs e)
        {
            double.TryParse(TBXNb1.Text, out n1);
            double.TryParse(TBXNb2.Text, out n2);
            resultat = Calculatrice.Soustraction(n1, n2);
            LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat);
        }

        //Ce bouton va permettre de faire une Division en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une Division
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDiv_Click(object sender, EventArgs e)
        {
            double.TryParse(TBXNb1.Text, out n1);
            double.TryParse(TBXNb2.Text, out n2);
            resultat = Calculatrice.Division(n1, n2);
            LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat);
        }

        private void LABResultat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
