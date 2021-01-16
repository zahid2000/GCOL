using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
        
            if (PlaneLeft1.Location.X <= 450)
            {
                timer1.Interval = 150;              
                PlaneLeft1.Left += 6;
            }
            else
            {
                timer1.Interval = 400;
                PlaneLeft1.Left += 5;
            }
            if (PlaneLeft1.Location.X >= 650)
            {
                PlaneLeft1.Visible = false;
                PlaneDown.Visible = true;
                timer3.Enabled = true;
                timer1.Enabled = false;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PlaneLeft2.Left += 4;
            timer2.Interval = 300;
            if (PlaneLeft2.Location.X >= 650)
            {
                PlaneLeft2.Visible = false;
                PlaneUp.Visible = true;
                timer4.Enabled = true;
                timer2.Enabled = false;
            }
            if (PlaneLeft2.Location.X == 564)
            {
                TurnLeft.Visible = true;
                Continue.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PlaneDown.Top += 2;
            timer3.Interval = 300;
            if (PlaneDown.Location.Y >= 108)
            {
                timer3.Enabled = false;
                PlaneDown.Visible = false;
                Fire.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 300;
            PlaneUp.Top -= 2;
            if (PlaneUp.Location.Y <= 108)
            {
                timer4.Enabled = false;
                PlaneUp.Visible = false;

            }
        }

       

        private void TurnLeft_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer2.Enabled = false;
            PlaneLeft2.Visible = false;
            PlaneDown1.Visible = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            Continue.Visible = false;
        }

        private void Continue_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            TurnLeft.Visible = false;

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            PlaneDown1.Top += 4;
            timer5.Interval = 300;
            if (PlaneDown1.Location.Y >= 200 )
            {
                timer5.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            PlaneDown.Top += 5;
            timer6.Interval = 400;
            if (PlaneDown.Location.Y >= 148)
            {
                PlaneDown.Visible = false;
                PlaneRight.Visible = true;
                Point point = new Point(876, 173);
                PlaneDown.Location = point;
                timer6.Enabled = false;
                timer7.Enabled = true;
            }
           
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            PlaneRight.Left -= 6;
            timer7.Interval = 400;
          
            if (PlaneRight.Location.X == 412)
            {
            
                timer7.Enabled = false;
                MessageBox.Show("CONGRATULATION!");
            }
        }
    }
}
