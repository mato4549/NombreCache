/**
 * Jeu du nombre caché
 * author : Mato
 * date 20/09/21
 */

using System;


namespace NombreCache
{
    class Program
    {


        //Module de saisie
        static int saisie(string message, int borneMin, int borneMax)
        {
            int nombre = 0;
            bool correct = false;

            while (!correct || nombre < borneMin || nombre > borneMax)
            {
                try
                {
                    Console.Write(message + " (entre " + borneMin + " et " + borneMax + ") = ");
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            return nombre;
        }
        
        static void Main(string[] args)
        {
            // Déclarations
            int valeur = 0, nbre = 1, essai = 0, min = 1, max =100;


            // Saisie du nombre à chercher
            valeur = saisie("Entrez le nombre à chercher", min, max);

            Console.Clear();

            //Saisie du premier essai
            essai = saisie("Entrez un essai", min, max);

            //Boucle sur la vérification de la reponse
            while (essai!= valeur)
            {
                //Test de l'essai par rapport à la valeur à trouver
                if (essai > valeur)
                {
                    Console.WriteLine("--> trop grand !");
                }
                else
                {
                    Console.WriteLine("--> trop petit !");
                }

                //Saisie d'un nouvel essai
                essai = saisie("Entrez un essai", min, max);
                
               
                //Compeur d'essais
                nbre++; 
            }

            //Valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");

           


            Console.ReadLine();
        }
    }
}
