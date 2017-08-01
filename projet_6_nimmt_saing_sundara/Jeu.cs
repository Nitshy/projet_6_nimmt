using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace projet_6_nimmt_saing_sundara
{
    class Jeu
    {
        private ArrayList joueur;

        public Jeu()
        {

        }

        public Jeu(ArrayList desJoueurs)
        {
            this.joueur = desJoueurs;
        }

        public void SetJoueur(ArrayList desJoueurs)
        {
            this.joueur = desJoueurs;
        }

        public ArrayList GetJoueur()
        {
            return this.joueur;
        }

    }
}
