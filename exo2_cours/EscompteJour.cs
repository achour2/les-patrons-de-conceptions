using System;
using System.Collections.Generic;
using System.Text;

namespace exo2
{
    internal class EscompteJour : IPrixCalcule
    {
        
        public double StratigieCalcule(string nom, double prix )
        {
            double resultat ;

            resultat = prix - ( prix * 0.15 ) ;
            return resultat ;
        }
    }
}