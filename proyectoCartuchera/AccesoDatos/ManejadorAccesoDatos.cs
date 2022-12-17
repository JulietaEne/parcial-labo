using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public static class ManejadorAccesoDatos
    {
        internal static SqlConnection Connection(string dataBase)
        {
            string connectionString = @$"Server = . ; Database = {dataBase}; Trusted_Connection = True; Trust Server Certificate=true";
            SqlConnection connection = new SqlConnection(connectionString); //puente entre el programa y la base de datos

            return connection;
        }

        internal static void CerrarConeccion(SqlConnection connection)
        {
            if (connection is not null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        internal static void AbrirConeccion(SqlConnection connection)
        {
            connection.Open();
        }

        internal static SqlCommand ConsultaSql(SqlConnection connection, string consultaSql)
        {
            SqlCommand command = new SqlCommand(); //encargado de transportar la consulta

            command.Connection = connection;//a la propiedad le seteo la sqlConnection
            command.CommandType = CommandType.Text;
            command.CommandText = $"{consultaSql}";

            return command;
        }

    }
}
