﻿using System;
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
    class DAO_almacen
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
            Almacenes objetoTablaAlmacen = (Almacenes)elObjeto;

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
            instruccionSQL = "INSERT INTO almacenes (num_almacen, cod_producto, cantidad, stock_minimo) VALUES ( " + 
                objetoTablaAlmacen.Num_almacen.ToString() + "," +
                pcs(objetoTablaAlmacen.Cod_producto) + "," +
                objetoTablaAlmacen.Cantidad.ToString() + "," +
                objetoTablaAlmacen.Stock_minimo.ToString() +
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
