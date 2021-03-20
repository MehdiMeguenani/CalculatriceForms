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
        double nb1,nb2,resultat;
        Boolean conversion;
        
        
        private void TBXNb1_TextChanged(object sender, EventArgs e)
        {
          TBXNb1.Clear();
        }

        private void TBXNb2_TextChanged(object sender, EventArgs e)
        {
            TBXNb2.Clear();
        }
        //Ce bouton va permettre de faire une addition en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une opération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddition_Click(object sender, EventArgs e)
        {
            conversion = double.TryParse(TBXNb1.Text, out nb1);
            if (conversion)//Verification si la conversion est bonne pour nb1
            {
                conversion = double.TryParse(TBXNb2.Text, out nb2);
                if (conversion)//Verification si la conversion est bonne pour nb2
                {
                    resultat = Calculatrice.Addition(nb1, nb2); //Utilisation de la méthode de la classe Calculatrice pour effectuer l'addition
                    LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat); //Utilisation du concat pour modifier LabRésultat et afficher un nouveaux texte (string) et le résultat (double) 
                }
                else
                    MessageBox.Show("Erreur de conversion nb2", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb2
            }
            else
                MessageBox.Show("Erreur de conversion nb1", "Problème conversion", MessageBoxButtons.OK); //Ouverture d'une boite de dialogue qui signale un problème de conversion du nb1

        }
        //Ce bouton va permettre de faire une Multiplication en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une multiplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNMulti_Click(object sender, EventArgs e)
        {
            conversion = double.TryParse(TBXNb1.Text, out nb1);
            if (conversion)//Verification si la conversion est bonne pour nb1
            {
                conversion = double.TryParse(TBXNb2.Text, out nb2);
                if (conversion) //Verification si la conversion est bonne pour nb2
                {
                   resultat = Calculatrice.Multiplication(nb1, nb2); // Utilisation de la méthode de la classe Calculatrice pour effectuer la multiplication
                   LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat); //Utilisation du concat pour modifier LabRésultat et afficher un nouveaux texte (string) et le résultat (double) 
                }
                else
                    MessageBox.Show("Erreur de conversion nb2", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb2
            }
            else
                MessageBox.Show("Erreur de conversion nb1", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb1

        }
        //Ce bouton va permettre de faire une Soustraction en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une  Soustraction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSoustraction_Click(object sender, EventArgs e)
        {
            conversion = double.TryParse(TBXNb1.Text, out nb1);
            if (conversion) //Verification si la conversion est bonne pour nb1
            {
                conversion = double.TryParse(TBXNb2.Text, out nb2);
                if (conversion) //Verification si la conversion est bonne pour nb2
                {
                    resultat = Calculatrice.Soustraction(nb1, nb2); // Utilisation de la méthode de la classe Calculatrice pour effectuer la soustraction
                    LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat); //Utilisation du concat pour modifier LabRésultat et afficher un nouveaux texte (string) et le résultat (double) 
                }
                else
                    MessageBox.Show("Erreur de conversion nb2", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb2
            }
            else
                MessageBox.Show("Erreur de conversion nb1", "Problème conversion", MessageBoxButtons.OK); //Ouverture d'une boite de dialogue qui signale un problème de conversion du nb1

        }

        //Ce bouton va permettre de faire une Division en transformant le texte du TBXNb1 et TBXNb2 en double et d'afficher le resultat en modifiant LABResultat
        /// <summary>
        /// Effectuer une Division
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDiv_Click(object sender, EventArgs e)
        {

            conversion = double.TryParse(TBXNb1.Text, out nb1);
            if (conversion)//Verification si la conversion est bonne pour nb1
            {
                conversion = double.TryParse(TBXNb2.Text, out nb2);
                if (conversion)//Verification si la conversion est bonne pour nb2
                {
                    resultat = Calculatrice.Division(nb1, nb2); //Utilisation de la méthode de la classe Calculatrice pour effectuer la division
                    LABResultat.Text = string.Concat("Résultat de l'addition : ", resultat); //Utilisation du concat pour modifier LabRésultat et afficher un nouveaux texte (string) et le résultat (double) 
                }
                else
                    MessageBox.Show("Erreur de conversion nb2", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb2
            }
            else
                MessageBox.Show("Erreur de conversion nb1", "Problème conversion", MessageBoxButtons.OK);//Ouverture d'une boite de dialogue qui signale un problème de conversion du nb1
        }

        private void LABResultat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
