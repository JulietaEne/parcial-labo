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


            string connectionString = @"Server = . ; Database = CartucheraDB; Trusted_Connection = True; Trust Server Certificate=true";
            SqlConnection connection = new SqlConnection(connectionString); //puente entre el programa y la base de datos

            connection.Open();
            SqlCommand command = new SqlCommand();

             //SqlCommand command = connection.CreateCommand();encargado de transportar la consulta
            command.Connection = connection;//a la propiedad le seteo la sqlConnection

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Cartucheras2";

            SqlDataReader infoLeida =  command.ExecuteReader();
           
            while (infoLeida.Read())//recorro la tabla registro a registro. Retorna true si hay datos por leer
            {
                //para mapear la informacion
                int id = infoLeida.GetInt32(0);
                int capacidad = infoLeida.GetInt32(1);
                float precioEvento = (float)infoLeida.GetDouble(2);
                string nombre = infoLeida.GetString(3);

                Cartuchera<Util> cartucheraLeida = new Cartuchera<Util>(id, precioEvento, capacidad, nombre);
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