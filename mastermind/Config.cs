using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Config
    {
        public int ligneReponse;
        public int ligneResultat;
        public int colonneReponse;

        public Config(int lReponse, int lResultat, int cReponse)
        {
            ligneReponse = lReponse;
            ligneResultat = lResultat;
            colonneReponse = cReponse;
        }

        public void Reset(ref int i)
        {
            i = 0;
        }
    }
}
