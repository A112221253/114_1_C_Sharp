using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOnPictureBox.Visible == true)
            {
                turnLightOn();
            }
            else
            {
                turnLightOff();
            }
        }
            private void turnLightOn()
        {
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "off";
        }
        private void turnLightOff()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "on";
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
