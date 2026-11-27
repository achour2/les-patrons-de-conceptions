using System;
namespace exo2
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Produit produit = new Produit("ordinateur" , 1800 );
            Console.WriteLine( $" Produit : { produit.Nom} et le prix de base : { produit.Prix}");


            Console.WriteLine( $" sans escopte : { produit.ObtenirPrixCalcule()}$");

            produit.Strategie = new EscompteJour();
            Console.WriteLine( $" avec EscompteJour : { produit.ObtenirPrixCalcule()}$");

            produit.Strategie = new EscomptePrefentiel();
            Console.WriteLine( $" avec EscomptePreferentiel : { produit.ObtenirPrixCalcule()}$");


        }
        

    }
}