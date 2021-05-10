using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amineportfolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blog b = new Blog();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Projet p = new Projet();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Testimonial t = new Testimonial();
            t.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blog b = new Blog();
            b.Show();
        }
    }
}
