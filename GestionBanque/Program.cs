using System;
using System.Collections.Generic;

namespace GestionBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque banque = new Banque();
            banque.Nom = "ING";

            Personne personne = new Personne();
            personne.Nom = "LY";
            personne.Prenom = "Khun";
            personne.DateNaissance = new DateTime(1982, 5, 6);

            Compte compte1 = new Epargne();
            compte1.Titulaire = personne;
            compte1.Depot(300);
            compte1.Numero = "001";

            Compte compte2 = new Courant();
            compte2.Titulaire = personne;
            compte2.Depot(100);
            compte2.Numero = "002";

            banque.Ajouter(compte1);
            banque.Ajouter(compte2);

            Console.WriteLine("Etes vous client(1) ou banquier(2)?");
            string choix = Console.ReadLine();
            if(choix == "1")
            {
                Console.WriteLine("Quel Compte souhaitez manipuler");
                string numero = Console.ReadLine();
                ICustomer aConsulter = banque[numero];
                ((Compte)aConsulter).AppliquerInteret();
                Console.WriteLine($"Solde avant retrait : " + aConsulter.Solde);
                aConsulter.Retrait(50);
                Console.WriteLine($"Solde apres retrait : " + aConsulter.Solde);
            }
            if (choix == "2")
            {
                Console.WriteLine("Quel Compte souhaitez manipuler");
                string numero = Console.ReadLine();
                IBanker aConsulter = banque[numero];
                Console.WriteLine($"Solde avant application interet : " + aConsulter.Solde);
                aConsulter.AppliquerInteret();
                Console.WriteLine($"Solde apres application interet : " + aConsulter.Solde);
            }
        }

        private static void afficherLeCompte(Compte compte)
        {
            Console.WriteLine("Numero: " + compte.Numero);
            Console.WriteLine($"Client: {compte.Titulaire.Nom} {compte.Titulaire.Prenom}");
            Console.WriteLine($"Solde: {compte.Solde}");
        }

        private static Courant CreerUnCompte()
        {
            Console.WriteLine("Entrer le nom du client");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrer le prenom du client");
            string prenom = Console.ReadLine();
            Console.WriteLine("Entrer la date de naissance du client");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Personne nouveauClient = new Personne();
            nouveauClient.Nom = nom;
            nouveauClient.Prenom = prenom;
            nouveauClient.DateNaissance = date;

            Console.WriteLine("Entrer le nouveau numero de compte");
            string numero = Console.ReadLine();
            Console.WriteLine("Entrer la limite de credit du nouveau compte");
            double limite = double.Parse(Console.ReadLine());
            Courant c = new Courant();
            c.Numero = numero;
            c.LigneCredit = limite;
            c.Titulaire = nouveauClient;

            c.Retrait(200);
            return c;
        }
    }
}
