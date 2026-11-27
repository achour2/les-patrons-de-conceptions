using System;
using System.Collections.Generic;
using System.Text;

namespace exo2
{
    internal class Produit
    {
       public string Nom { get; set;}
       public double Prix { get ; set ;}

      public Produit ( string nom , double prix)
        {
            this.Nom = nom ;
            this.Prix = prix;
        }

    }
}