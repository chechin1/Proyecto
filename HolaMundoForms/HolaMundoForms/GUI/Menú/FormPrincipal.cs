using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoForms
{
    public partial class frmPrincipal : Form
    {
        //PROPIEDADES DE LA CLASE
        public double numero1, numero2, resultado;
        public int i = 0;

        public frmPrincipal()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = (double) nudNumero1.Value;
            numero2 = (double) nudNumero2.Value;
            if(cbOperacion.SelectedIndex == 0)
            {
                resultado = numero1 + numero2;
            }
            if(cbOperacion.SelectedIndex == 1)
            {
                resultado = numero1 - numero2;
            }
            if(cbOperacion.SelectedIndex == 2)
            {
                resultado = numero1 * numero2;
            }
            if(cbOperacion.SelectedIndex == 3)
            {
                
                
                resultado = numero1 / numero2;
                 
            
            }
            
            MessageBox.Show("El resultado es: " + resultado);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cbOperacion.SelectedIndex = 0;
        }

        private void nudNumero2_ValueChanged(object sender, EventArgs e)
        {
            if(cbOperacion.SelectedIndex == 3)
            {
                if(nudNumero2.Value == 0)
                {
                    btnSumar.Enabled = false;
                }
                else
                {
                    btnSumar.Enabled = true;
                }
            }
        }

        private void cbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperacion.SelectedIndex == 3)
            {
                if (nudNumero2.Value == 0)
                {
                    btnSumar.Enabled = false;
                }
                
            }
            else
            {
                btnSumar.Enabled = true;
            }
        }

        

        
    }
}
