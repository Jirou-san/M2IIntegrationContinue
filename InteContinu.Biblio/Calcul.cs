using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteContinu.Biblio
{
    public static class Calcul
    {
        //Méthode avec erreur volontaire
        public static int GetInt(string s)
        {
            return (int.Parse(s) +1);
        }

    }
}
