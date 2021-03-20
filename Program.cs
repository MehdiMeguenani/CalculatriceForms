using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_Simplfifié
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string mes = "Voulez vous rentrer dans la calculatrice", titre = "Calculatrice simplifié ";

            MessageBoxButtons bouttons = MessageBoxButtons.YesNo;
            DialogResult reponse = MessageBox.Show(mes, titre, bouttons);
            if (reponse == DialogResult.Yes)
            {
                Application.Run(new Form1());
            }
            else
            {

            }

        }
    }
}
