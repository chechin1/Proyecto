using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HolaMundoForms.Catálogos;

namespace HolaMundoForms.GUI.Menú
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin miVentana = new frmLogin();
            miVentana.Show();
            
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductos miVentana = new frmProductos();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlmacen miVentana = new FrmAlmacen();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProveedores miVentana = new FrmProveedores();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmClientes miVentana = new FrmClientes();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSucursales miVentana = new FrmSucursales();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario miVentana = new FrmUsuario();
            miVentana.ShowDialog();
            miVentana.Dispose();
        }

       

       
    }
}
