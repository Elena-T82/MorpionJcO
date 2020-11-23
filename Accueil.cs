using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Morpion_JvO
{
    public partial class Accueil : Form
    {
        int[] tab = new int[8];
        bool LeJoueurGagne;
        int Pfo = 0;
        int victoireJoueur = 1;
        int victoireBot = 1;


        public Accueil()
        {
            InitializeComponent();
            music2 = new SoundPlayer("fond.wav");
            music2.PlayLooping();

        }

        private SoundPlayer music2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            LeJoueurGagne = false;

            cmdCase1.Text = "";
            cmdCase1.Enabled = true;
            cmdCase2.Text = "";
            cmdCase2.Enabled = true;
            cmdCase3.Text = "";
            cmdCase3.Enabled = true;
            cmdCase4.Text = "";
            cmdCase4.Enabled = true;
            cmdCase5.Text = "";
            cmdCase5.Enabled = true;
            cmdCase6.Text = "";
            cmdCase6.Enabled = true;
            cmdCase7.Text = "";
            cmdCase7.Enabled = true;
            cmdCase8.Text = "";
            cmdCase8.Enabled = true;
            cmdCase9.Text = "";
            cmdCase9.Enabled = true;
            Vainqueur.Text = "";


            for (int i = 0; i < 8; i++)
            {
                tab[i] = 0;
                Pfo = 0;
            }
        }
        private void OrdiJoue(int p)
        {
            switch (p)
            {
                case -1:   //première case que joue l'ordi
                    if (cmdCase5.Text == "")
                    {
                        cmdCase5.Text = "O";
                        cmdCase5.Enabled = false;
                        tab[1] += 3;
                        tab[4] += 3;
                        tab[6] += 3;
                        tab[7] += 3;
                    }

                    
                    else if (cmdCase3.Text == "")
                        {
                            cmdCase3.Text = "O";
                            cmdCase3.Enabled = false;
                            tab[0] += 3;
                            tab[5] += 3;
                        }

                    else if (cmdCase1.Text == "")
                    {
                        cmdCase1.Text = "O";
                        cmdCase1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[6] += 3;
                    }

                    else if (cmdCase7.Text == "")
                    {
                        cmdCase7.Text = "O";
                        cmdCase7.Enabled = false;
                        tab[2] += 3;
                        tab[3] += 3;
                        tab[7] = +3;
                    }

                    else if (cmdCase9.Text == "")
                    {
                        cmdCase9.Text = "O";
                        cmdCase9.Enabled = false;
                        tab[2] += 3;
                        tab[5] += 3;
                        tab[6] += 3;
                    }

                    break;


                case 0:

                    if (cmdCase1.Text == "")
                    {
                        cmdCase1.Text = "O";
                        cmdCase1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[6] += 3;
                    }

                    else if (cmdCase2.Text == "")
                        {
                            cmdCase2.Text = "O";
                            cmdCase2.Enabled = false;
                            tab[0] += 3;
                            tab[4] += 3;
                        }

                        else if (cmdCase3.Text == "")
                            {
                                cmdCase3.Text = "O";
                                cmdCase3.Enabled = false;
                                tab[0] += 3;
                                tab[5] += 3;
                                tab[7] += 3;
                            }

                    break;
        

                case 1:

                    if (cmdCase4.Text == "")
                    {
                        cmdCase4.Text = "O";
                        cmdCase4.Enabled = false;
                        tab[1] += 3;
                        tab[3] += 3;
                    }
                    else if (cmdCase5.Text == "")
                        {
                            cmdCase5.Text = "O";
                            cmdCase5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else if (cmdCase6.Text == "")
                            {
                                cmdCase6.Text = "O";
                                cmdCase6.Enabled = false;
                                tab[1] += 3;
                                tab[5] += 3;
                            }
                        
                     break;

                case 2:

                    if (cmdCase7.Text == "")
                    {
                        cmdCase7.Text = "O";
                        cmdCase7.Enabled = false;
                        tab[2] += 3;
                        tab[3] += 3;
                        tab[7] += 3;
                    }

                    else if (cmdCase8.Text == "")
                        {
                            cmdCase8.Text = "O";
                            cmdCase8.Enabled = false;
                            tab[2] += 3;
                            tab[4] += 3;
                        }

                        else if (cmdCase9.Text == "")
                            {
                                cmdCase9.Text = "O";
                                cmdCase9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[6] += 3;
                            }

                    break;

                case 3:

                    if (cmdCase1.Text == "")
                    {
                        cmdCase1.Text = "O";
                        cmdCase1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[6] += 3;
                    }
                    else if (cmdCase4.Text == "")
                        {
                            cmdCase4.Text = "O";
                            cmdCase4.Enabled = false;
                            tab[1] += 3;
                            tab[3] += 3;
                        }

                        else if (cmdCase7.Text == "")
                            {
                                cmdCase7.Text = "O";
                                cmdCase7.Enabled = false;
                                tab[2] += 3;
                                tab[3] += 3;
                                tab[7] += 3;
                            }

                    break;

                case 4:

                    if (cmdCase2.Text == "")
                    {
                        cmdCase2.Text = "O";
                        cmdCase2.Enabled = false;
                        tab[0] += 3;
                        tab[4] += 3;
                    }

                    else if (cmdCase5.Text == "")
                        {
                            cmdCase5.Text = "O";
                            cmdCase5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }

                        else if (cmdCase8.Text == "")
                            {
                                cmdCase8.Text = "O";
                                cmdCase8.Enabled = false;
                                tab[2] += 3;
                                tab[4] += 3;
                            }

                    break;

                case 5:

                    if (cmdCase3.Text == "")
                    {
                        cmdCase3.Text = "O";
                        cmdCase3.Enabled = false;
                        tab[0] += 3;
                        tab[5] += 3;
                        tab[7] += 3;
                    }

                    else if (cmdCase6.Text == "")
                        {
                            cmdCase6.Text = "O";
                            cmdCase6.Enabled = false;
                            tab[1] += 3;
                            tab[5] += 3;
                        }

                        else if (cmdCase9.Text == "")
                            {
                                cmdCase9.Text = "O";
                                cmdCase9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[6] += 3;
                            }

                    break;

                case 6:

                    if (cmdCase3.Text == "")
                    {
                        cmdCase3.Text = "O";
                        cmdCase3.Enabled = false;
                        tab[0] += 3;
                        tab[5] += 3;
                        tab[7] += 3;
                    }
                    else if (cmdCase5.Text == "")
                        {
                            cmdCase5.Text = "O";
                            cmdCase5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else if (cmdCase7.Text == "")
                            {
                                cmdCase7.Text = "O";
                                cmdCase7.Enabled = false;
                                tab[2] += 3;
                                tab[3] += 3;
                                tab[7] += 3;
                            }
                        
                    break;

                case 7:

                     if (cmdCase1.Text == "")
                    {
                        cmdCase1.Text = "O";
                        cmdCase1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[6] += 3;
                    }
                    else if (cmdCase5.Text == "")
                        {
                            cmdCase5.Text = "O";
                            cmdCase5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else if (cmdCase9.Text == "")
                            {
                                cmdCase9.Text = "O";
                                cmdCase9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[6] += 3;
                            }
                        
                    break;
            }
            TrouveGagnant();
        }
            private void TrouveGagnant()
        {
            
                if ((tab[0] == 9) || (tab[1] == 9) || (tab[2] == 9) || (tab[3] == 9) || (tab[4] == 9) || (tab[5] == 9) || (tab[6] == 9) || (tab[7] == 9))
                {
                    Vainqueur.Text = "Le Bot à gagné ! Dommage :(";
                    ScoreBot.Text = ("Bot : " + victoireBot);
                    victoireBot++;

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;

                   
                }
                if ((tab[0] == 15) || (tab[1] == 15) || (tab[2] == 15) || (tab[3] == 15) || (tab[4] == 15) || (tab[5] == 15) || (tab[6] == 15) || (tab[7] == 15))
                {
                    Vainqueur.Text = "Le joueur à gagné ! Bravo :D";
                    ScoreJoueur.Text = ("Joueur : " + victoireJoueur);
                    victoireJoueur++;

                    LeJoueurGagne = true;
                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                   
            }
        }
        
        private void JoueurJoue(int p)

        {
            switch (p)
            {
                case 1:
                    cmdCase1.Text = "X";
                    cmdCase1.Enabled = false;
                    tab[0] += 5;
                    tab[3] += 5;
                    tab[6] += 5;
                    break;

                case 2:
                    cmdCase2.Text = "X";
                    cmdCase2.Enabled = false;
                    tab[0] += 5;
                    tab[4] += 5;
                    break;

                case 3:
                    cmdCase3.Text = "X";
                    cmdCase3.Enabled = false;
                    tab[0] += 5;
                    tab[5] += 5;
                    tab[7] += 5;
                    break;

                case 4:
                    cmdCase4.Text = "X";
                    cmdCase4.Enabled = false;
                    tab[1] += 5;
                    tab[3] += 5;
                    break;

                case 5: cmdCase5.Text = "X";
                    cmdCase5.Enabled = false;
                    tab[1] += 5;
                    tab[4] += 5;
                    tab[6] += 5;
                    tab[7] += 5;
                    break;

                case 6: cmdCase6.Text = "X";
                    cmdCase6.Enabled = false;
                    tab[1] += 5;
                    tab[5] += 5;
                    break;

                case 7: cmdCase7.Text = "X";
                    cmdCase7.Enabled = false;
                    tab[2] += 5;
                    tab[3] += 5;
                    tab[7] += 5;
                    break;

                case 8:
                    cmdCase8.Text = "X";
                    cmdCase8.Enabled = false;
                    tab[2] += 5;
                    tab[4] += 5;
                    break;

                case 9:
                    cmdCase9.Text = "X";
                    cmdCase9.Enabled = false;
                    tab[2] += 5;
                    tab[5] += 5;
                    tab[6] += 5;
                    break;
            }

            TrouveGagnant();

            if (LeJoueurGagne == false)
            {
                Pfo = OrdiCherche();

                if (Pfo == -1)
                {
                    OrdiJoue(-1);
                }
                else
                {
                    OrdiJoue(Pfo);
                }
            }
        }
        private int OrdiCherche()
        {
            Pfo = -1;

            for (int i = 0; i < 8; i++)
            {
                if (tab[i] == 6)
                {
                    Pfo = i;
                    break;
                }
                else if (tab[i] == 10)
                    {
                        Pfo = i;
                        break;
                    }
                
            }
            return (Pfo);
        }


        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCase1_Click(object sender, EventArgs e)
        {
            JoueurJoue(1);
        }

        private void cmdCase2_Click(object sender, EventArgs e)
        {
            JoueurJoue(2);
        }

        private void cmdCase3_Click(object sender, EventArgs e)
        {
            JoueurJoue(3);
        }

        private void cmdCase4_Click(object sender, EventArgs e)
        {
            JoueurJoue(4);
        }

        private void cmdCase5_Click(object sender, EventArgs e)
        {
            JoueurJoue(5);
        }

        private void cmdCase6_Click(object sender, EventArgs e)
        {
            JoueurJoue(6);
        }

        private void cmdCase7_Click(object sender, EventArgs e)
        {
            JoueurJoue(7);
        }

        private void cmdCase8_Click(object sender, EventArgs e)
        {
            JoueurJoue(8);
        }

        private void cmdCase9_Click(object sender, EventArgs e)
        {
            JoueurJoue(9);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ScoreBot.Text = "";
            ScoreJoueur.Text = "";
            victoireBot = 1;
            victoireJoueur = 1;
        }

        
    }
}
