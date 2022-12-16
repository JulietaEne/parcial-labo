using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
//using BibliotecaDeClases;

namespace ManejadorDeArchivos
{
    public class AccesoDatos
    {

      /*  public List<Cartuchera<Util>> ObtenerDatos()
        {
            string connectionString = @"Server = .\. ; Database = Cartuchera; Trusted_Connection = True;";
            //<- Server: mi instancia (servername server manaer studio)
            //Database : nombre que le di a mi base de datos
            //ultimo parametro algo de los permisos

            SqlConnection connection = new SqlConnection(connectionString); //puente entre programa y base de datos

            connection.Open();

            SqlCommand comando = new SqlCommand(); //encargado de transportar la consulta. Para usarlo hay que setear algunas propiedades del objeto

            comando.Connection = connection; //especifico la coneccion
            comando.CommandType = System.Data.CommandType.Text; //de que tipo va a ser el comando 
            comando.CommandText = "SELECT * FROM ----";//"/*aca va la sentencia que le quiero pasar para la busqueda*///";
        
 //           SqlDataReader infoLeidaDeTabla = comando.ExecuteReader();
 //           while (infoLeidaDeTabla.Read())
 //           {
                //aca van los atributos de la tabla que me estoy mapeando
                /*
                 int id = infoLeidaDeTabla.GetInt32(0); <- leo un dato tipo int de columna 0
                    . 
                    . recordar que si el dato puede ser nulo, tengo que valudarlo antes //.IsDBNull();
                 */
                //Al terminar de mapear, puedo instancial mi objeto 
                //
//               Cartuchera<Util> listaCartucheras = new Cartuchera<Util>();
//           }
//            if (connection.State == ConnectionState.Open)
//            {
//                connection.Close();
//            }

//            return objeto;

//        }

    }
}
