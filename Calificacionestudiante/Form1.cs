using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calificacionestudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            double NOTA1, NOTA2, NOTA3, NOTA4, SUMA, RESULTADO;
            NOTA1 = double.Parse(TXTNOTA1.Text);
            /*E ESTAMOS DICIENDO QUE A NOTA UNO  LE ENTREGUE CONVIERTA A DOUBLE LO QUE ESTE EN "TXTNOTA1.TEXT"*/
            NOTA2 = double.Parse(TXTNOTA2.Text);
            NOTA3 = double.Parse(TXTNOTA3.Text);
            NOTA4 = double.Parse(TXTNOTA4.Text);
            SUMA = NOTA1 + NOTA2 + NOTA3 + NOTA4;
            RESULTADO = SUMA / 4;

            //el resultado de todo

            LBLRESULTADO.Text = Convert.ToString(RESULTADO);

            //pa que nos muestre lo que anteriormente pusimos visible:false

            label6.Visible = true;
            LBLRESULTADO.Visible = true;





        }

        private void BTNBORRAR_Click(object sender, EventArgs e)
        {

            //estoy previniendo que no me ejecute con campos nulos con if y else

            if (TXTNOTA1.Text == "" || TXTNOTA2.Text == "" || TXTNOTA3.Text == "" || TXTNOTA4.Text == "" ) {

                MessageBox.Show("Todos lo campos deben de estar diligenciados", "mensaje de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                double NOTA1, NOTA2, NOTA3, NOTA4, SUMA, RESULTADO;
                NOTA1 = double.Parse(TXTNOTA1.Text);
                /*E ESTAMOS DICIENDO QUE A NOTA UNO  LE ENTREGUE CONVIERTA A DOUBLE LO QUE ESTE EN "TXTNOTA1.TEXT"*/
                NOTA2 = double.Parse(TXTNOTA2.Text);
                NOTA3 = double.Parse(TXTNOTA3.Text);
                NOTA4 = double.Parse(TXTNOTA4.Text);
                SUMA = NOTA1 + NOTA2 + NOTA3 + NOTA4;
                RESULTADO = SUMA / 4;

                //el resultado de todo

                LBLRESULTADO.Text = Convert.ToString(RESULTADO);

                //pa que nos muestre lo que anteriormente pusimos visible:false

                label6.Visible = true;
                LBLRESULTADO.Visible = true;



            }


            TXTNOTA1.Text = String.Empty;
            TXTNOTA2.Text = String.Empty;
            TXTNOTA3.Text = String.Empty;
            TXTNOTA4.Text = String.Empty;

            label6.Visible = false;
            LBLRESULTADO.Visible = false;

            //para que el cursor me lo ponga en el campo txtnota1

            TXTNOTA1.Focus();
        }

        private void TXTNOTA1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
