using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace mastermind
{
    static public class Plateau
    {
        //Initialisation du plateau
        public static void initPlateau(ref PictureBox[,] p, ref PictureBox p1, ref PictureBox p2, ref PictureBox p3, 
            ref PictureBox p4, ControlCollection c)
        {
            p = new PictureBox[4, 12];
            int y = 62;
            int x = 560;
            int j;
            for (j = 0; j < 12; j++)
            {
                int i;
                for (i = 0; i < 4; i++)
                {
                    p[i, j] = new PictureBox();
                    p[i, j].Location = new Point(y, x);
                    p[i, j].Size = new Size(30, 25);
                    p[i, j].BackColor = Color.Transparent;
                    p[i, j].BorderStyle = BorderStyle.FixedSingle;
                    c.Add(p[i, j]);
                    y += 50;
                }
                x -= 40;
                y = 62;
                i = 0;
            }
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
        }

        //Initialisation des labels des résultats
        public static void initLabelResultat(ref Label[] l, ControlCollection c)
        {
            l = new Label[12];
            int s = 300;
            int t = 565;
            for (int k = 0; k < 12; k++)
            {
                l[k] = new Label();
                l[k].Location = new Point(s, t);
                l[k].Text = "-";
                l[k].Size = new Size(100, 25);
                l[k].Font = new Font("Calibri", 12);
                c.Add(l[k]);
                t -= 40;
            }
        }

        //Couleur au hasard
        public static void reponseCouleur(List<PictureBox> listPic)
        {
            foreach (PictureBox p in listPic)
            {
                p.BackColor = ChooseColor();
            }
        }

        public static Color ChooseColor()
        {
            int p = De.LanceLeDe();
            if (p == 1)
                return Color.Red;
            else if (p == 2)
                return Color.Yellow;
            else if (p == 3)
                return Color.Blue;
            else if (p == 4)
                return Color.Orange;
            else if (p == 5)
                return Color.Green;
            else if (p == 6)
                return Color.White;
            else if (p == 7)
                return Color.Purple;
            else if (p == 8)
                return Color.Pink;
            else
                return Color.Transparent;
        }
    }
}
