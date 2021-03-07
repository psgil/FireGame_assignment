using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_assignment
{
    public partial class Form1 : Form
    {
        private static Random rd = new Random();
        winner winner = new winner();
        int Shotcount = 0;

        int Shotawaycount = 0;

        //onload all the button must be disable 
        public void btnDisable()
        {
            load_btn.Enabled = false;
            spin_btn.Enabled = false;
            shoot_btn.Enabled = false;
            shootaway_btn.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
            //calling the method
            btnDisable();
            //pass the value to the global 
            winner.shotChance = rd.Next(1, 4);
            winner.shotAwayChance = rd.Next(1, 3);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            //here we are going to exit the game at any time 
            this.Close();
        }


        // load btn loading game
        private void load_btn_Click(object sender, EventArgs e)
        {
            load_btn.Enabled = false;
            spin_btn.Enabled = true;
            pictureBox1.Image = FireGame_assignment.Properties.Resources.load2;

        }
        // start button enabling next buttons
        private void start_btn_Click(object sender, EventArgs e)
        {
            load_btn.Enabled = true;
            start_btn.Enabled = false;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spin_btn_Click(object sender, EventArgs e)
        {
            spin_btn.Enabled = false;
            shoot_btn.Enabled = true;
            shootaway_btn.Enabled = true;
            pictureBox1.Image = FireGame_assignment.Properties.Resources.spin2;
        }


        // giving chances to buttons
        public int chance(int trigger, int chance)
        {

            if (trigger == chance)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

       
        // shoot button working and genrating sound
        private void shoot_btn_Click(object sender, EventArgs e)
        {

            Shotcount++;
            if (Shotcount <= 4)
            {

                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_assignment.Properties.Resources.fire);
                obj.Play();
                if (chance(winner.shotChance, Shotcount) == 1)
                {
                    MessageBox.Show("You loss the game ");
                    shoot_btn.Enabled = false;
                    shootaway_btn.Enabled = false;
                }

            }

            pictureBox1.Image = FireGame_assignment.Properties.Resources.shoot1;
        }

        // shoot awa button giving another chance
        private void shootaway_btn_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = FireGame_assignment.Properties.Resources.shoot2;
            Shotawaycount++;
            if (Shotawaycount <= 2)
            {
                if (chance(winner.shotAwayChance, Shotawaycount) == 1)
                {
                    shootaway_btn.Enabled = false;
                    MessageBox.Show("Chances are over");
                    exit_btn.Enabled = true;
                }
            }
        }
    }
    public class winner {
            public int shotChance { get; set; }
        public int shotAwayChance { get; set; }
    }
}
