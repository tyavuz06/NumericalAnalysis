using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalAnaliz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewtonRaphson form2 = new NewtonRaphson();
            form2.ShowDialog();
        }

        private void btnBiSection_Click(object sender, EventArgs e)
        {
            BiSection form3 = new BiSection();
            form3.ShowDialog();
        }

        private void btnGoldenRate_Click(object sender, EventArgs e)
        {
            GoldenRate form4 = new GoldenRate();
            form4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
