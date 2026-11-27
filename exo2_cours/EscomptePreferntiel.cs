using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace exo2
{
    internal class EscomptePrefentiel : IPrixCalcule
    {
       

        public double StratigieCalcule(string nom, double prix )
        {
            double resultat ;

            resultat = prix - ( prix * 0.26 ) ;
            return resultat ;
        }
    }
}