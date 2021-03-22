using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    public class Combinaison
    {
        public List<string> couleur;

        public Combinaison(List<string> c)
        {
            couleur = c;
        }

        public List<string> Check (Combinaison rep)
        {
            List<string> reponse = new List<string>();
            //Vérification réponses exactes
            for (int i = 0; i < 4; i++)
            {
                if (rep.couleur[i].ToString() == this.couleur[i].ToString())
                {
                    reponse.Add("●");
                    rep.couleur[i] = "checked_" + i;
                    this.couleur[i] = "done_" + i;
                }
            }
            //Vérification des couleurs
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rep.couleur[j].ToString() == this.couleur[i].ToString())
                    {
                        reponse.Add("○");
                        rep.couleur[j] = "checked_" + j;
                        this.couleur[i] = "done_" + i;
                    }
                }
            }
            return reponse;
        }
    }
}
