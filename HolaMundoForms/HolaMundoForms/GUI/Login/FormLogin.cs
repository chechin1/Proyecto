using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HolaMundoForms.GUI.Menú;
using HolaMundoForms.DB;

namespace HolaMundoForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.VERIFICA_USUARIO_PASSWORD())
            {
                this.Hide();
                frmMenu miVentana = new frmMenu();
                miVentana.ShowDialog();
                miVentana.Dispose();
                
                

            }

        }

        //REVISAR SI EL USUARIO ESTA REGISTRADO
        public void  REVISAR_USUARIO_REGISTRADO()
        {

        }

        public bool VERIFICA_USUARIO_PASSWORD()
        {
            bool validar = true;
            //VALIDAR QUE EL USUARIO NO SEA "BLANCO"

            if (this.txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                validar = false;
                return validar;
            }


            //VALIDAR PASSWORD
            if (this.txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una contraseña");
                validar = false;
                return validar;
            }

            //CREAR EL OBJETO QUE ME CONECTA A LA BASE DE DATOS...
            ConexionMYSQL objetoODBC = new ConexionMYSQL();
            //CREAMOS LA SENTENCIA SQL QUE ME DEVUELVE LOS DATOS QUE CONCUERDAN CON LA CONDICION "WHERE"
            string SentenciaSQL;
            SentenciaSQL = "select usuario from sys_usuarios where usuario= '" + txtUsuario.Text + "' and contrasena = '" + txtPwd.Text + "'";
            //VALIDAR QUE LA COMBINACION DE USUARIO Y CONTRASEÑA EXISTA
            if (!objetoODBC.MYSQL_EXISTE_DATO(SentenciaSQL))
            {
                //SI NO EXISTE ESA COMBINACION, LOS DATOS SON INCORRECTOS
                MessageBox.Show("DATOS DE ACCESO INCORRECTOS!", "ERROR");
                validar = false;
                return validar;
            }
            return validar;

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNuevoUsuario y = new FrmNuevoUsuario();
            y.ShowDialog();
            y.Dispose();
        }

        
    }
}
