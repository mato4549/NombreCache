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
        static void Main(string[] args)
        {
            // Déclarations
            int valeur = 0, essai, nbre = 1;
            bool correct = false;

            // Saisie du nombre à chercher

            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            Console.Clear();

            //Saisie du premier essai
            Console.Write("Entrez le nombre à chercher = ");
            essai = int.Parse(Console.ReadLine());

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
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez le nombre à chercher = ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }
                
               
                //Compeur d'essais
                nbre++; 
            }

            //Valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");

           


            Console.ReadLine();
        }
    }
}
