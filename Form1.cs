using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ArreglosMultidimensionales_G2_2024_II
{
    public partial class Form1 : Form
    {
        Multidimensional m1;
        Multidimensional m2;
        Multidimensional m3;
        bool cambioOperando = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    if( txtbDisplay.Text == "")
                    {
                        string error = "No debes dejar dejar el display " +
                            "sin un valor de la matriz";
                        throw new ApplicationException(error);
                    }


                    if (!cambioOperando)
                    {
                        m1 = Multidimensional.Leer(txtbDisplay.Text);
                        lbOperando1.Text = m1.ToString();
                        cambioOperando = true;
                    }
                    else
                    {
                        m2 = Multidimensional.Leer(txtbDisplay.Text);
                        lbOperando2.Text = m2.ToString();
                        cambioOperando = false;
                    }
                }
                catch(ApplicationException error)
                {
                    MessageBox.Show("Error: " + error.Message, "Error Personalizado",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                catch (FormatException error)
                {
                    MessageBox.Show("Error: " + error.Message, "Error de Formato",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error, "Error General",
                      MessageBoxButtons.OK,MessageBoxIcon.Error );

                }


            }

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            m3 = m1 + m2;
             lbResultado.Text = m3.ToString();
        }
    }
}
