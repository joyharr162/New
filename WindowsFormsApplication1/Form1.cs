//Created by Joy Harris
//January 25 2017
//An interactive adventure game
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
        Image cat = Properties.Resources.catPiskel;
        Image forwardHero = Properties.Resources.person;
        Image backHero = Properties.Resources.personBack;
        Image leftHero = Properties.Resources.personLeft;
        Image rightHero = Properties.Resources.personRight;
        Image monster1 = Properties.Resources.monsterPiskel;
        Image monster2 = Properties.Resources.monsterPiskel2;
        int monsterX = 500;
        int monsterY = 500;
        int heroX = 500;
        int heroY = 500;
        int speed = 2;
        int scene = 0;
        int playerLives = 3;
        int exitX;
        int exitY;
        int startScene = 0;
        int flash = 0;
        int num1;
        int num2;
        Boolean leftKey = false, rightKey = false, upKey = false, downKey = false;

        //create random generator
        Random randGen = new Random();

        //brushes
        SolidBrush doorBrush = new SolidBrush(Color.Sienna);
        SolidBrush goldBrush = new SolidBrush(Color.Gold);
        SolidBrush whiteBrush = new SolidBrush(Color.PeachPuff);

        public Form1()
        {
            InitializeComponent();
            chaseTimer.Start();
            Refresh();
        }

        //timer changes hero position
        private void chaseTimer_Tick(object sender, EventArgs e)
        {
            if (leftKey == true && heroX > 0)
            {
               heroX = heroX - speed;
            }
            else if (rightKey == true && heroX < 920)
            {
                heroX = heroX + speed;
            }
            if (upKey == true && heroY > 0)
            {
                heroY = heroY - speed;
            }
            else if (downKey == true && heroY < 520)
            {
                heroY = heroY + speed;
            }
            pictureBox3.Location = new Point(heroX, heroY);
            Rectangle r1 = new Rectangle(heroX, heroY, 126, 130);
            Rectangle r2 = new Rectangle(this.Width - 175, 0, 125, 200);
            if (r1.IntersectsWith(r2))
            {
                scene = 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics fg = this.CreateGraphics();

            //controls character movement
            if (e.KeyCode == Keys.Up)
            {
                upKey = true;
                pictureBox3.Image = backHero;
                pictureBox4.Image = backHero;
            }
            else
            {
                upKey = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                downKey = true;
                pictureBox3.Image = forwardHero;
                pictureBox4.Image = forwardHero;
            }
            else
            {
                downKey = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightKey = true;
                pictureBox3.Image = rightHero;
                pictureBox4.Image = rightHero;
            }
            else
            {
                rightKey = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftKey = true;
                pictureBox3.Image = leftHero;
                pictureBox4.Image = leftHero;
            }
            else
            {
                leftKey = false;
            }

            //switch to control scenes
            #region
            switch (e.KeyCode)
            {
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
                        scene = 14;
                    }
                    else if (scene == 5)
                    {
                        scene = 6;
                    }
                    else if (scene == 6)
                    {
                        scene = 8;
                    }
                    else if (scene == 8)
                    {
                        scene = 9;
                    }
                    else if (scene == 9)
                    {
                        if (exitLabel.ForeColor == Color.OrangeRed)
                        {
                            scene = 10;
                        }
                    }
                    else if (scene == 11)
                    {
                        scene = 13;
                    }
                    else if (scene == 10)
                    {
                        scene = 11;
                    }
                    else if (scene == 14)
                    {
                        scene = 15;
                    }
                    else if (scene == 15)
                    {
                        scene = 16;
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
                    else if (scene == 5)
                    {
                        scene = 7;
                    }
                    else if (scene == 8)
                    {
                        scene = 5;
                    }
                    else if (scene == 11)
                    {
                        scene = 12;
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
            #endregion

            //scene actions
            switch (scene)
            {
                case 0:
                    fg.FillRectangle(doorBrush, this.Width - 175, 0, 125, 200);
                    fg.FillEllipse(goldBrush, this.Width - 170, 100, 20, 20);
                    break;
                case 1:
                    if (scene == 1)
                    {
                        label1.Text = "You step through the door and see something on the ground. Pick it up? \n\nA = Yes";
                    }
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, this.Width - 500, this.Height / 2, 50, 30);
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 2:
                    inventoryLabel.Text = "Flashlight      Map";
                    pictureBox4.Visible = false;
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, 100, 100, 800, 500);
                    label1.Text = "You realize this is a map of your surroundings. You are at a fork with four tunnels, which have no distinguishable differences. Which do you go down?  A = Tunnel 1  S = Tunnel 2  W = Tunnel 3  D = Tunnel 4";
                    break;
                case 3:
                    //tunnel 1
                    label1.Text = "You come to a locked gate. What do you do?  A = Pick Lock  S = Turn Back";
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
                case 7:
                    label1.Text = "You yell 'Who's there?' but no one answers... Suddenly something grabs you from behind. You lose a life";
                    break;
                case 8:                 
                    pictureBox4.Visible = false;
                    label1.Text = "You run a long way. Just when you think you can't go any further, you find an unlocked sewer gate. You decide to go through it, and on the other side it's totally dark. When you feel your shoes start to get wet. \n\nA = Keep Going \nS = Turn Back";
                    break;
                case 9:
                    label1.Text = "You should probably find yourself an exit...";
                    exitX = randGen.Next(10, 600);
                    exitY = randGen.Next(50, 550);
                    fg.Clear(Color.Black);
                    pictureBox4.Visible = false;
                    exitLabel.Location = new Point(exitX, exitY);
                    exitLabel.Visible = true;
                    break;
                case 10:
                    exitLabel.Visible = false;
                    label1.Text = "You've reached a save point. You'll spawn here if you die. Press A to continue.";
                    startScene = 11;
                    break;
                case 11:
                    label1.Text = "You turn a corner and suddenly you here a faint meow. It's a kitten! Do you pick it up? \n\nA = Pick it up \nS = Leave it on the ground";
                    pictureBox3.Visible = true;
                    pictureBox3.Image = cat;
                    break;
                case 12:
                    label1.Text = "You don't pick up the kitten. You heartless creature. \n\nA = Change Your Mind";
                    break;
                case 13:;
                    label1.Text = "It was a trap! The walls of the cave start closing in. Conveniently, there is a trapdoor in the ceiling. But how can you get to it?";
                    fg.FillRectangle(whiteBrush, 10, 200, 50, 50);
                    fg.FillRectangle(whiteBrush, 90, 200, 50, 50);
                    fg.FillRectangle(whiteBrush, 50, 150, 50, 50);
                    Rectangle r1 = new Rectangle(heroX, heroY, 126, 130);
                    Rectangle r3 = new Rectangle(10, 150, 130, 100);
                    if (r1.IntersectsWith(r3))
                    {
                        scene = 14;
                    }
                    break;
                case 14:
                    //case for mini game
                    while (flash < 10)
                    {
                        if (label1.ForeColor == Color.White)
                        {
                            label1.ForeColor = Color.Lime;
                        }
                        else if (label1.ForeColor == Color.Lime)
                        {
                            label1.ForeColor = Color.White;
                        }
                        label1.Text = "MINI GAME";
                    }
                    label1.Text = "Answer 3 questions in a row correctly to sucessfully stack the boxes. Press A to start.";
                    break;
                case 15:
                    num1 = randGen.Next(50, 100);
                    num2 = randGen.Next(50, 100);
                    label1.Text = num1 + "  +  " + num2;
                    //case 14 case 15 case 16 r3 add some comments and edited scene pathway
                    break;
                case 16:
                    label1.ForeColor = Color.Black;
                    this.BackColor = Color.White;
                    label1.Text = "You pull yourself up throught the trapdoor, and suddenly it gets really bright. As your eyes adjust, you realize your finally outside! You win!";
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //controls character movement
            if (e.KeyCode == Keys.Up)
            {
                upKey = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                downKey = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftKey = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightKey = false;
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

        }

        private void exitLabel_MouseMove(object sender, MouseEventArgs e)
        {
            exitLabel.ForeColor = Color.OrangeRed;
            label1.Text = "Good job! Press A to continue.";
        }

        //unused method
        private void exitLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
