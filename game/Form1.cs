using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private bool first;
        private Image Tic;
        private Image Tac;
        public Form1()
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(game.Properties.Resources.Tic))
            {
                Tic = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(game.Properties.Resources.Tac))
            {
                Tac = Image.FromStream(ms);
            }
            first = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
