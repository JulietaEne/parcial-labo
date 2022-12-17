using System;
using System.Collections.Generic;
using BibliotecaDeClases;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class CartucheraDAO
    {

        public List<Cartuchera<Util>> ObtenerCartucheras()
        {
            List<Cartuchera<Util>> listaCartucheras = new List<Cartuchera<Util>>();


            string connectionString = @"Server = . ; Database = CartucheraDB; Trusted_Connection = True; ";
            SqlConnection connection = new SqlConnection(connectionString); //puente entre el programa y la base de datos

            connection.Open();

            SqlCommand cmd = connection.CreateCommand(); //encargado de transportar la consulta
            cmd.Connection = connection;//a la propiedad le seteo la sqlConnection

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cartucheras2";

            SqlDataReader infoLeida =  cmd.ExecuteReader();
           
            while (infoLeida.Read())//recorro la tabla registro a registro. Retorna true si hay datos por leer
            {
                //para mapear la informacion
                int id = infoLeida.GetInt32(0);
                int capacidad = infoLeida.GetInt32(1);
                float precioEvento = infoLeida.GetFloat(2);
                string nombre = infoLeida.GetString(3);

                Cartuchera<Util> cartucheraLeida = new Cartuchera<Util>(precioEvento, capacidad, nombre);
                listaCartucheras.Add(cartucheraLeida);
            }

            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return listaCartucheras;
        }

    }
}