using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Calculatrice
{
    /*Classe Calcultrice 
     * Auteur : Mehdi Meguenani
     * Date de création : 22 janvier 2021
     * Cette classe permet de faire des calcul de type soustraction, division, multiplication, addition
     * */
    /// <summary>
    /// Effectue les opération comme une calcultrice telle que : Addition, Soustraction, Multiplication et Division.
    /// </summary>
    static public class Calculatrice
    {
        // Permet d'aditionner deux variable nb1 et nb2 qui sont de type double et de retourner une somme 
       /// <summary>
       /// retourne nb1 + nb2
       /// </summary>
       /// <param name="nb1"></param>
       /// <param name="nb2"></param>
       /// <returns></returns>
        static public double Addition(double nb1, double nb2)
        {
            return nb1 + nb2;

        }
        // Permet de soustraire les paramètre double nb1 et nb2 
        /// <summary>
        /// retourne nb1 - nb2
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>

        static public double Soustraction(Double nb1, Double nb2)
        {
            return nb1 - nb2;
        }
        //Permet de multiplier deux variables nb1 et nb2 
        /// <summary>
        /// retourne nb1*nb2
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>
        static public double Multiplication(Double nb1, Double nb2)
        {
            return nb1 * nb2;
        }
        //Permet de diviser les paramètre double nb1 et nb2 
        /// <summary>
        /// retourne nb1/nb2 si nb2 !=0
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>
        static public double Division(Double nb1, Double nb2)
        {
            if (nb2 == 0)
            {
                throw new DivideByZeroException("Pas possible");
            }
                
            return nb1 / nb2;
        }

    }
}
