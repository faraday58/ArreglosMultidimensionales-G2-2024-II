using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArreglosMultidimensionales_G2_2024_II
{
    public partial class Form1 : Form
    {
        Multidimensional m1;
        Multidimensional m2;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (Char)Keys.Enter)
            {
                m1 = Multidimensional.Leer(txtbDisplay.Text);
                lbOperando1.Text = m1.ToString();
            }

        }
    }
}
