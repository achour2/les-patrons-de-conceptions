using System;
using System.Collections.Generic;
using System.Text;

namespace exo2
{
    internal class EscomptePrefentiel : IPrixCalcule
    {
        public double resultat {get ; set ;}
        public double StratigieCalcule(string nom, double prix )
        {
            return resultat ;
        }
    }
}