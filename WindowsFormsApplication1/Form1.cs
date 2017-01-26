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
        Image Door = Properties.Resources.DoorPiskel;
        int heroX = 500;
        int heroY = 500;
        int speed = 2;
        int scene = 0;
        int playerLives = 3;
        int exitX;
        int exitY;
        int num1;
        int num2;

        //sounds
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.Short_triumphal_fanfare_John_Stracke_815794903);
        SoundPlayer catPlayer = new SoundPlayer(Properties.Resources.cat_meow_x);
        SoundPlayer doorCreak = new SoundPlayer(Properties.Resources.door_creak);
        SoundPlayer doorLock = new SoundPlayer(Properties.Resources.door_lock);
        SoundPlayer waterPlayer = new SoundPlayer(Properties.Resources.Spooky_Water_Drops_SoundBible_com_50164895);
        Boolean leftKey = false, rightKey = false, upKey = false, downKey = false;

        //create random generator
        Random randGen = new Random();

        //brushes
        SolidBrush doorBrush = new SolidBrush(Color.Sienna);
        SolidBrush goldBrush = new SolidBrush(Color.Gold);
        SolidBrush brownBrush = new SolidBrush(Color.SandyBrown);
        SolidBrush whiteBrush = new SolidBrush(Color.PeachPuff);
        public Form1()
        {
            InitializeComponent();
            chaseTimer.Start();
            Refresh();
        }

        public void Collisions()
        {
            if (pictureBox3.Bounds.IntersectsWith(doorBox.Bounds))
            {
                scene = 1;
            }
        }

        //timer changes hero position
        private void chaseTimer_Tick(object sender, EventArgs e)
        {
            if (leftKey == true && heroX > 0)
            {
               heroX = heroX - speed;
            }
            else if (rightKey == true && heroX < 950)
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
            if (heroX < 0)
            {
                scene = 1;
            }
            if (playerLives == 0)
            {
                loseLabel.Visible = true;
                checkButton.Enabled = false;
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
                    else if (scene == 4)
                    {
                        scene = 2;
                    }
                    else if (scene == 3)
                    {
                        scene = 11;
                    }
                    else if (scene == 5)
                    {
                        scene = 6;
                    }
                    else if (scene == 6)
                    {
                        scene = 8;
                    }
                    else if (scene == 7)
                    {
                        scene = 2;
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
                    else if (scene == 12)
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
                    Collisions();

                    break;
                case 1:
                    doorBox.Visible = false;
                    if (scene == 1)
                    {
                        doorCreak.Play();
                        label1.Text = "You hear noises in the distance... you start to get scared. You see something on the ground. Pick it up? A = Yes";
                    }
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, this.Width - 500, this.Height / 2, 50, 30);
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 2:
                    inventoryLabel.Text = "Flashlight      Map        Paper Clip";
                    pictureBox4.Visible = false;
                    fg.Clear(Color.Black);
                    label1.Text = "You realize this is a map of your surroundings. You are at a fork with four tunnels, which have no distinguishable differences. Which do you go down?  A = Tunnel 1  S = Tunnel 2  W = Tunnel 3  D = Tunnel 4";
                    break;
                case 3:
                    //tunnel 1
                    label1.Text = "You come to a locked gate. What do you do?  A = Pick the lock with your paper clip  S = Turn Back";
                    break;
                case 4:
                    //tunnel 2
                    label1.Text = "You trip, fall, and hit your hit your head. You lose a life. Press A to go back.";
                    playerLives--;
                    livesLabel.Text = "LIVES : " + playerLives;
                    break;
                case 5:
                    //tunnel3
                    label1.Text = "You hear noises again. How will you investigate?  A = Investigate Quietly S= Ask Who's There";
                    break;
                case 6:
                    //tunnel4
                    label1.Text = "You pull out your flashlight and wave it around. The light allows you to see pairs of eyes in the distance. A = Run!";
                    break;
                case 7:
                    label1.Text = "You yell 'Who's there?' but no one answers... Suddenly something grabs you from behind. You lose a life. Press A to go back.";
                    playerLives--;
                    livesLabel.Text = "LIVES: " + playerLives;
                    break;
                case 8:                 
                    pictureBox4.Visible = false;
                    label1.Text = "You run a long way. Just when you think you can't go any further, you find an unlocked sewer gate. You decide to go through it, and on the other side it's totally dark. You start to feel your shoes getting wet. A = Keep Going S = Turn Back";
                    //play water dripping sound
                    waterPlayer.Play();
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
                    label1.Text = "Congradulations! For making it this far, you get an extra life. Press A to continue";
                    playerLives++;
                    livesLabel.Text = "LIVES: " + playerLives; 
                    break;
                case 11:
                    label1.Text = "You turn a corner and suddenly you here a faint meow. It's a kitten! Do you pick it up?    A = Pick it up S = Leave it on the ground";
                    //play kitten sound
                    catPlayer.Play();
                    pictureBox3.Visible = true;
                    pictureBox3.Image = cat;
                    break;
                case 12:
                    label1.Text = "You don't pick up the kitten. You heartless creature. A = Change Your Mind";
                    break;
                case 13:
                    //pictureBox3.Image = forwardHero;
                    label1.Text = "It was a trap! The walls of the cave start closing in. Conveniently, there is a trapdoor in the ceiling. But how can you get to it? Use the arrow keys.";
                    boxBox.Visible = true;
                    //detect if the player contacts the stack of boxes
                    if (boxBox.Bounds.IntersectsWith(pictureBox3.Bounds))
                    {
                        scene = 14;
                    }
                    break;
                case 14:
                    //case for mini game
                    boxBox.Visible = false;
                    label1.Text = "MINI GAME! Answer this math question correctly to sucessfully stack the boxes. Press A to start.";
                    break;
                case 15:
                    num1 = randGen.Next(100, 200);
                    num2 = randGen.Next(100, 200);
                    numberLabel.Visible = true;
                    numberLabel.Text = num1 + "  +  " + num2;
                    checkButton.Visible = true;
                    inputBox.Visible = true;
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

        private void exitLabel_MouseMove(object sender, MouseEventArgs e)
        {
            exitLabel.ForeColor = Color.OrangeRed;
            label1.Text = "Good job! Press A to continue.";
        }

        //checks the answers to the mini game
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == num1 + num2 + "") //if player answers question correctly
            {
                label1.Text = "Nice! You stacked the boxes. You pull yourself up through the trapdoor, and suddenly it gets really bright. As your eyes adjust, you realize your finally outside! YOU WIN!";
            }
            else if (inputBox.Text != num1 + num2 + "")
            {
                winSound.Play();
                label1.Text = "Wrong! You lost a life. Try again";
                playerLives--;
                livesLabel.Text = "LIVES : " + playerLives;
                checkButton.Visible = false;
                inputBox.Visible = false;
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox3.Location = new Point(heroX, heroY - 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
