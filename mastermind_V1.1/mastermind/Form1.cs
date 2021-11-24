using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        //Initialisation des Variables
        PictureBox[,] plateau;
        Label[] labelResultat;
        List<string> listReponse = new List<string>();
        Config conf = new Config(0, 0, 0);
        int partiesG = 0;
        int partiesP = 0;

        public void Start()
        {
            if (plateau != null && labelResultat != null)
            {
                foreach (PictureBox p in plateau)
                {
                    p.Dispose();
                }
                foreach (Label l in labelResultat)
                {
                    l.Dispose();
                }
            }

            conf.Reset(ref conf.colonneReponse);
            conf.Reset(ref conf.ligneReponse);
            conf.Reset(ref conf.ligneResultat);

            List<PictureBox> solutionPicture = new List<PictureBox> { picSolution1, picSolution2, picSolution3, picSolution4 };
            //picSolution1.BackColor = Color.Green;
            //picSolution2.BackColor = Color.Yellow;
            //picSolution3.BackColor = Color.White;
            //picSolution4.BackColor = Color.Blue;
            Plateau.reponseCouleur(solutionPicture);
            Plateau.initPlateau(ref plateau, ref picSolution1, ref picSolution2, ref picSolution3, ref picSolution4, Controls);
            Plateau.initLabelResultat(ref labelResultat, Controls);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Start();
        }

        public void ajoutReponse(string c)
        {
            listReponse.Add(c);

            if (conf.colonneReponse == 4)
            {
                //Liste des bonnes réponses
                List<string> listSolution = new List<string>();
                string sol_1 = picSolution1.BackColor.ToString();
                listSolution.Add(sol_1);
                string sol_2 = picSolution2.BackColor.ToString();
                listSolution.Add(sol_2);
                string sol_3 = picSolution3.BackColor.ToString();
                listSolution.Add(sol_3);
                string sol_4 = picSolution4.BackColor.ToString();
                listSolution.Add(sol_4);

                //Vérification des résultats
                Combinaison reponse = new Combinaison(listReponse);
                Combinaison solution = new Combinaison(listSolution);
                List<string> resultat = solution.Check(reponse);

                //Affichage des résultats
                foreach (string r in resultat)
                {
                    labelResultat[conf.ligneResultat].Text += " " + r;  
                }

                //Réinitialisation de la colonne et changement de ligne
                conf.Reset(ref conf.colonneReponse);
                conf.ligneReponse++;
                conf.ligneResultat++;

                //Vérification partie gagnée
                if (labelResultat[conf.ligneResultat - 1].Text == "- ● ● ● ●")
                {
                    picSolution1.Visible = true;
                    picSolution2.Visible = true;
                    picSolution3.Visible = true;
                    picSolution4.Visible = true;
                    DialogResult dialogResult = MessageBox.Show("Rejouer ?", "Vous avez remporté la partie  :)", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        partiesG++;
                        lblG.Text = ("Parties gagnées: " + partiesG);
                        Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                
                //Vérification partie perdue
                if (conf.ligneReponse == 12)
                {
                    picSolution1.Visible = true;
                    picSolution2.Visible = true;
                    picSolution3.Visible = true;
                    picSolution4.Visible = true;
                    DialogResult dialogResult = MessageBox.Show("Rejouer ?", "Vous avez perdu la partie  :(", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        partiesP++;
                        lblP.Text = ("Parties perdues: " + partiesP);
                        Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                resultat.Clear();
                listReponse.Clear();
            }
        }

        //Boutons couleurs
        private void Red_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Red;
            conf.colonneReponse++;
            ajoutReponse(Red.BackColor.ToString());
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Yellow;
            conf.colonneReponse++;
            ajoutReponse(Yellow.BackColor.ToString());
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Blue;
            conf.colonneReponse++;
            ajoutReponse(Blue.BackColor.ToString());
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Orange;
            conf.colonneReponse++;
            ajoutReponse(Orange.BackColor.ToString());
        }

        private void Green_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Green;
            conf.colonneReponse++;
            ajoutReponse(Green.BackColor.ToString());
        }

        private void White_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.White;
            conf.colonneReponse++;
            ajoutReponse(White.BackColor.ToString());
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Purple;
            conf.colonneReponse++;
            ajoutReponse(Purple.BackColor.ToString());
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            plateau[conf.colonneReponse, conf.ligneReponse].BackColor = Color.Pink;
            conf.colonneReponse++;
            ajoutReponse(Pink.BackColor.ToString());
        }
    }
}
