using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HolaMundoForms.DB;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using HolaMundoForms.BO;

namespace HolaMundoForms.DAO
{
    class DAO_clientes
    {
        //PROPIEDADES
        ConexionMYSQL oBaseDatos = new ConexionMYSQL();
        ConexionMYSQL oBaseDatosODBC = new ConexionMYSQL();
        DataSet dsProductos = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;


        //METODOS

        //INSERTAR UN NEUVO REGISTRO EN LA BASE DE DATOS

        public int agregarNuevoRegistro(object elObjeto)
        {
            //CONVERTIMOS NUESTRO OBJETO GENERICO A UNO DE LA CLASE
            Cat_clientes objetoTablaCliente = (Cat_clientes)elObjeto;

            //PREPARAMOS EL COMANDO DE MySQL
            comandoMySQL = new MySqlCommand();

            //PREPARAR EL DATASET
            dsProductos = new DataSet();

            //PREPARAR EL DATA ADAPTER
            datAdapterMySQL = new MySqlDataAdapter();

            //ESTABLECER LA CONEXION
            comandoMySQL.Connection = oBaseDatos.miConectorNET;
            oBaseDatos.establecerConexionNET();



            //ARMAR LA INSTRUCCION MySQL: insert
            instruccionSQL = "INSERT INTO cat_clientes (razon_social, rfc, calle, num_ext, num_int, referencia, colonia, codigo_postal, municipio, estado, telefono, correo) VALUES ( " +
                pcs(objetoTablaCliente.Razon_social) + "," +
                pcs(objetoTablaCliente.Rfc) + "," +
                pcs(objetoTablaCliente.Calle) + "," +
                pcs(objetoTablaCliente.Num_ext) + "," +
                pcs(objetoTablaCliente.Num_int) + "," +
                pcs(objetoTablaCliente.Referencia) + "," +
                pcs(objetoTablaCliente.Colonia) + "," +
                pcs(objetoTablaCliente.Codigo_postal) + "," +
                pcs(objetoTablaCliente.Municipio) + "," +
                pcs(objetoTablaCliente.Estado) + "," +
                pcs(objetoTablaCliente.Tel) + "," +
                pcs(objetoTablaCliente.Correo) +
                " ) ";

            comandoMySQL.CommandText = instruccionSQL;
            int resultadoDelComando = comandoMySQL.ExecuteNonQuery();

            if (resultadoDelComando <= 0)
            {
                return 0; //HAY ERROR
            }


            return 1;
        }

        public string pcs(string Valor)
        {
            return "'" + Valor + "'";
        }
    }
}
