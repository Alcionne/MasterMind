using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    public class De
    {
        private static Random random = new Random();
        public static int LanceLeDe()
        {
            return random.Next(1, 9);
        }
    }
}
