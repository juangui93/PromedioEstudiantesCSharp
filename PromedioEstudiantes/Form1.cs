using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);
            double promedio = 0;

            promedio = ((nota1 + nota2 + nota3) / 3);

            lblPromedio.Text = Convert.ToString(promedio); 

            if (promedio >= 3.5)  {
                MessageBox.Show("YA PUEDES ROBAR PLATA.",
                    "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("DESCANSA EN PAZ.",
                    "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            lblPromedio.Text = "0";
            txtNota1.Focus(); 
        }
    }
}
