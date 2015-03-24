using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class Sys_usuarios
    {
        //PROPIEDADES
        long id;
        string usuario;
        string contrasena;
        string nombre_completo;
        string tipo_usuario;

        public long Id
        {
            get { return id;  }
            set { id = value; }

        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }

        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }

        }
        public string Minombre
        {
            get { return nombre_completo; }
            set { nombre_completo = value; }

        }
        public string TipoUsuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }

        }
    }
}
