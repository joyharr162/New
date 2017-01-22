//add code for mini game 1
//fix the map
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //images and variables
        Image forwardHero = Properties.Resources.person;
        Image backHero = Properties.Resources.personBack;
        Image lefthero = Properties.Resources.personLeft;
        Image righthero = Properties.Resources.personRight;
        Image monster1 = Properties.Resources.monsterPiskel;
        Image monster2 = Properties.Resources.monsterPiskel2;
        int monsterX = 500;
        int monsterY = 500;
        int heroX = 500;
        int heroY = 500;
        int monsterSpeed = 2;
        int scene = 0;
        int playerLives = 3;

        SolidBrush doorBrush = new SolidBrush(Color.Sienna);
        SolidBrush goldBrush = new SolidBrush(Color.Gold);
        SolidBrush whiteBrush = new SolidBrush(Color.PeachPuff);

        public Form1()
        {
            InitializeComponent();
            //create rectangles for monsters and hero
            Rectangle r1 = new Rectangle(monsterX, monsterY, 62, 62);
            Rectangle r2 = new Rectangle(monsterX + 50, monsterY + 50, 62, 62);
            Rectangle r3 = new Rectangle(heroX, heroY, 126, 130);

            if (r1.IntersectsWith(r2))
            {
                //    MessageBox.Show("Intersected!");
            }
            else
            {
                //    MessageBox.Show("Non-Intersected!");
            }
            Refresh();
        }

        //unused timer method
        private void chaseTimer_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics fg = this.CreateGraphics();

            //controls character movement and switches scenes
            switch (e.KeyCode)
            {
                case Keys.Left:

                    break;
                case Keys.Right:

                    break;
                case Keys.Down:

                    break;
                case Keys.Up:
                    if (scene == 0)
                    {
                        scene = 1;
                    }
                    break;
                case Keys.A:
                    if (scene == 1)
                    {
                        scene = 2;
                    }
                    else if (scene == 2)
                    {
                        scene = 3;
                    }
                    else if (scene == 3)
                    {
                        //go to mini game 1;
                    }
                    break;
                case Keys.S:
                    if (scene == 1)
                    {
                        label1.Text = "You leave it on the ground";
                    }
                    if (scene == 2)
                    {
                        scene = 4;
                    }
                    else if (scene == 3)
                    {
                        scene = 2;
                    }
                    break;
                case Keys.W:
                    if (scene == 2)
                    {
                        scene = 5;
                    }
                    break;
                case Keys.D:
                    if (scene == 2)
                    {
                        scene = 6;
                    }
                    break;
            }

            //controls scenes
            switch (scene)
            {
                case 1:
                    if (scene == 1)
                    {
                        label1.Text = "You step through the door and see something at your feet. Pick it up? Yes A, no S.";
                    }
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, this.Width - 500, this.Height / 2, 50, 30);
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 2:
                    pictureBox4.Visible = false;
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, 100, 70, 800, 500);
                    label1.Text = "You realize this is a map of your surroundings. You are at a fork with four tunnels, which have no distinguishable differences. Which do you go down?\n\nA = Tunnel 1\nS = Tunnel 2\nW = Tunnel 3\nD = Tunnel 4";
                    break;
                case 3:
                    //tunnel 1
                    label1.Text = "You come to a locked gate. What do you do?\n\nA = Pick Lock \nS = Turn Back";
                    break;
                case 4:
                    //tunnel 2
                    label1.Text = "You trip, fall, and hit your hit your head. You lose a life.";
                    playerLives--;
                    livesLabel.Text = "LIVES : " + playerLives;
                    break;
                case 5:
                    //tunnel3
                    label1.Text = "You hear noises. How will you investigate?\n\nA = Investigate Quietly \nS= Ask Who's There";
                    break;
                case 6:
                    //tunnel4
                    label1.Text = "You pull out your flashlight and wave it around. The light allows you to see pairs of eyes in the distance. Do you run or try to fight?\n\nA = Run! \nS = Fight!";
                    break;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r1 = new Rectangle(monsterX, monsterY, 62, 62);
            Rectangle r2 = new Rectangle(monsterX + 50, monsterY + 50, 62, 62);
            Rectangle r3 = new Rectangle(heroX, heroY, 126, 130);
            pictureBox1.Location = new Point(monsterX, monsterY);
            pictureBox2.Location = new Point(monsterX + 50, monsterY + 50);
            pictureBox3.Location = new Point(heroX, heroY);
            e.Graphics.FillRectangle(doorBrush, this.Width - 175, 0, 125, 200);
            e.Graphics.FillEllipse(goldBrush, this.Width - 170, 100, 20, 20);

        }

    }
}
