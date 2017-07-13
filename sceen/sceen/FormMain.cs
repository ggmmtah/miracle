using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sceen
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            label1.Text = ("Resolution: " + screenWidth + "x" + screenHeight);

            foreach (var screen in System.Windows.Forms.Screen.AllScreens)
            {
                listBox1.Items.Add("Device Name: " + screen.DeviceName);
                listBox1.Items.Add("Bounds: " +
                    screen.Bounds.ToString());
                listBox1.Items.Add("Type: " +
                    screen.GetType().ToString());
                listBox1.Items.Add("Working Area: " +
                    screen.WorkingArea.ToString());
                listBox1.Items.Add("Primary Screen: " +
                    screen.Primary.ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
