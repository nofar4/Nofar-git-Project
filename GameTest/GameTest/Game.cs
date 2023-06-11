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
using System.Threading;

namespace GameTest
{
    public partial class Game : Form
    {
       

        int roadSpeed,
            wordSpeed,
            playerSpeed = 12,
            life = 3,
            pointer1 = 0,
            pointer2 = 1,
            countWords = 0,
            score = 0, // how many words collected
            wordImage; //every word will get a number to use with the random function

        Random rand = new Random(),
               wordPosition = new Random();

        bool goLeft, goRight, forced = false, firstTime = true;

        SoundPlayer playCrash = new SoundPlayer(Properties.Resources.fuck_it_all1),
                    reset = new SoundPlayer(Properties.Resources.gta_san_andreas_ah_shit_here_we_go_again1),
                    win = new SoundPlayer(Properties.Resources.metal_slug_mission_complete1),
                    collectRight = new SoundPlayer(Properties.Resources.nice_LCUymM81),
                    collectWrong = new SoundPlayer(Properties.Resources.incorrect),
                    gameSound = new SoundPlayer(Properties.Resources.AMBTraf_Highway__ID_0122__BSB);

       

        Image[] words = new Image[] { Properties.Resources.a, Properties.Resources.b, Properties.Resources.c, Properties.Resources.d,
                                      Properties.Resources.e, Properties.Resources.f, Properties.Resources.g, Properties.Resources.h,
                                      Properties.Resources.i, Properties.Resources.j, Properties.Resources.k,Properties.Resources.l,
                                      Properties.Resources.m,Properties.Resources.n,Properties.Resources.o,Properties.Resources.p,
                                      Properties.Resources.q,Properties.Resources.r,Properties.Resources.s,Properties.Resources.t,
                                      Properties.Resources.u,Properties.Resources.v,Properties.Resources.w,Properties.Resources.x,
                                      Properties.Resources.y,Properties.Resources.z};


        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameTimer.Stop();
            SoundsStop();
        }

        public Game()
        {
            InitializeComponent();
            ResetGame();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }



        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }




        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft == true && player.Left > 8)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 374)
            {
                player.Left += playerSpeed;
            }



            Road1.Top += roadSpeed;
            Road2.Top += roadSpeed;

            if (Road2.Top > 480)
            {
                Road2.Top = -480;
            }
            if (Road1.Top > 480)
            {
                Road1.Top = -480;
            }

            Word1.Top += wordSpeed;
            Word2.Top += wordSpeed;

            if (Word1.Top > 491)
            {
                changeWords(Word1, ref pointer1, forced);
            }
            if (Word2.Top > 491)
            {
                changeWords(Word2, ref pointer2, forced);
            }


            if (player.Bounds.IntersectsWith(Word1.Bounds) || player.Bounds.IntersectsWith(Word2.Bounds))
            {
                if (player.Bounds.IntersectsWith(Word1.Bounds))
                {


                    if (score == pointer1)
                    {
                        CollectRightSound();
                        txtScore.Text = "Score: " + ++score;
                    }


                    else
                    {
                        CollectWrongSound();
                        life--;
                        switch (life)
                        {
                            case 2:
                                heart3.Image = Properties.Resources.skull;
                                break;
                            case 1:
                                heart2.Image = Properties.Resources.skull;
                                break;
                            case 0:
                                heart1.Image = Properties.Resources.skull;
                                break;
                            default:
                                gameOver();
                                break;
                        }
                    }
                    changeWords(Word1, ref pointer1, forced);
                }


                else if (player.Bounds.IntersectsWith(Word2.Bounds))
                {

                    if (score == pointer2)
                    {
                        CollectRightSound();
                        txtScore.Text = "Score: " + ++score;
                    }


                    else
                    {
                        CollectWrongSound();
                        life--;
                        switch (life)
                        {
                            case 2:
                                heart3.Image = Properties.Resources.skull;
                                break;
                            case 1:
                                heart2.Image = Properties.Resources.skull;
                                break;
                            case 0:
                                heart1.Image = Properties.Resources.skull;
                                break;
                            default:
                                gameOver();
                                break;
                        }
                    }
                    changeWords(Word2, ref pointer2, forced);
                }




                if (score > 4 && score < 9)
                {
                    roadSpeed = 8;
                    wordSpeed = 10;
                }
                if (score >= 10 && score <= 15)
                {
                    roadSpeed = 10;
                    wordSpeed = 12;
                }
                if (score >= 15 && score <= 21)
                {
                    roadSpeed = 12;
                    wordSpeed = 14;
                }
                if (score > 21 && score <= 26)
                {
                    roadSpeed = 14;
                    wordSpeed = 16;
                    if (score == 26)
                    {
                        GameWinner();
                    }
                }


            }
        }





        private void changeWords(PictureBox tempWord, ref int pointer, bool forced)
        {
            Random random = new Random();
            int number = rand.Next(3, 5);
            if (countWords % number == 0)
            {
                tempWord.Image = words[score];
                pointer = score;
            }
            else
            {
                wordImage = rand.Next(0, 25);
                tempWord.Image = words[wordImage];
                pointer = wordImage;
            }
            countWords++;




            tempWord.Top = wordPosition.Next(100, 400) * -1;

            if ((string)tempWord.Tag == "wordLeft")
            {
                tempWord.Left = wordPosition.Next(0, 160);
            }
            if ((string)tempWord.Tag == "wordRight")
            {
                tempWord.Left = wordPosition.Next(240, 385);
            }
        }

        private void gameOver()
        {
            PlayCrashSound();
            gameTimer.Stop();
            Explosion.Visible = true;
            player.Controls.Add(Explosion);
            Explosion.Location = new Point(-8, 5);
            Explosion.BackColor = Color.Transparent;
            firstTime = false;

            btnStart.Enabled = true;

        }

        private void GameWinner()
        {
            winner.Image = Properties.Resources.winner;
            winner.Visible = true;
            gameTimer.Stop();
            firstTime = false;
            btnStart.Enabled = true;
            WinGameSound();
        }

        private void ResetGame()
        {
            ResetSound();
            btnStart.Enabled = false;
            Explosion.Visible = false;
            winner.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            pointer1 = 0;
            pointer2 = 1;
            countWords = 0;
            life = 3;
            heart1.Image = Properties.Resources.heart;
            heart2.Image = Properties.Resources.heart;
            heart3.Image = Properties.Resources.heart;

            // might need to add select car

            roadSpeed = 6;
            wordSpeed = 8;

            Word1.Top = wordPosition.Next(200, 500) * -1;
            Word1.Left = wordPosition.Next(0, 160);

            Word2.Top = wordPosition.Next(200, 500) * -1;
            Word2.Left = wordPosition.Next(240, 385);

            gameTimer.Start();
        }

        private void PlayCrashSound()
        {
            playCrash.Play();
        }



        private void WinGameSound()
        {
            win.Play();
        }

        private void CollectRightSound()
        {
            collectRight.Play();
        }

        private void CollectWrongSound()
        {
            collectWrong.Play();
        }



        private void ResetSound()
        {
            if (!firstTime)
            {
                reset.Play();
            }
        }

        private void SoundsStop()
        {
            playCrash.Stop();
            win.Stop();
            collectRight.Stop();
            collectWrong.Stop();
            reset.Stop();
        }




    }
}
