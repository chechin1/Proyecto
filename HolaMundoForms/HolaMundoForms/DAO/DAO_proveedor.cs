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
    class DAO_proveedor
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
            Cat_proveedor objetoTablaProveedor = (Cat_proveedor)elObjeto;

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
            instruccionSQL = "INSERT INTO cat_proveedor (razon_social, rfc, calle, num_ext, num_int, referencia, colonia, codigo_postal, municipio, estado, telefono, correo) VALUES ( " +
                pcs(objetoTablaProveedor.Razon_social) + "," +
                pcs(objetoTablaProveedor.Rfc) + "," +
                pcs(objetoTablaProveedor.Calle) + "," +
                pcs(objetoTablaProveedor.Num_ext) + "," +
                pcs(objetoTablaProveedor.Num_int) + "," +
                pcs(objetoTablaProveedor.Referencia) + "," +
                pcs(objetoTablaProveedor.Colonia) + "," +
                pcs(objetoTablaProveedor.Codigo_postal) + "," +
                pcs(objetoTablaProveedor.Municipio) + "," +
                pcs(objetoTablaProveedor.Estado) + "," +
                pcs(objetoTablaProveedor.Tel) + "," +
                pcs(objetoTablaProveedor.Correo) +
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
