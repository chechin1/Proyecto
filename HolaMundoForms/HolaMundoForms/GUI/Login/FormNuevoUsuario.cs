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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin miVentana = new frmLogin();
            miVentana.Show();
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
