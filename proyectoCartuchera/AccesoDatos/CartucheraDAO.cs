using System;
using System.Collections.Generic;
using BibliotecaDeClases;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace AccesoDatos
{
    public class CartucheraDAO
    {
        static string dataBase;
        static string table;
        static SqlConnection connection = null;

        static CartucheraDAO()
        {
            dataBase = "CartucheraDB";
            table = "Cartucheras2";
            try
            {
                connection = ManejadorAccesoDatos.Connection(dataBase);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cartuchera<Util>> ObtenerCartucheras()
        {
            List<Cartuchera<Util>> listaCartucheras = new List<Cartuchera<Util>>();

            try
            {
                ManejadorAccesoDatos.AbrirConeccion(connection);


                SqlDataReader infoLeida = ManejadorAccesoDatos.ConsultaSql(connection, $"SELECT * FROM {table}").ExecuteReader();//command.ExecuteReader();

                while (infoLeida.Read())//recorro la tabla registro a registro. Retorna true si hay datos por leer
                {
                    Cartuchera<Util> cartucheraLeida = MapearCartuchera(infoLeida);
                    listaCartucheras.Add(cartucheraLeida);
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                ManejadorAccesoDatos.CerrarConeccion(connection);
            }
            

            return listaCartucheras;
        }

        public void AgregarCartuchera(Cartuchera<Util> miCartuchera)
        {
            try
            {
                ManejadorAccesoDatos.AbrirConeccion(connection);

               
                SqlCommand command = ManejadorAccesoDatos.ConsultaSql(connection, $"SET IDENTITY_INSERT {table} ON INSERT INTO {table} VALUES (@id, @precioTope, @capacidadCartuchera, @nombre) SELECT * FROM {table} SET IDENTITY_INSERT {table} OFF");

                 command.Parameters.AddWithValue("@id", miCartuchera.IdCartuchera);
                 command.Parameters.AddWithValue("@precioTope", miCartuchera.PrecioEvento);
                 command.Parameters.AddWithValue("@capacidadCartuchera", miCartuchera.CapacidadCartuchera);
                 command.Parameters.AddWithValue("@nombre", miCartuchera.Nombre);

                 command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ManejadorAccesoDatos.CerrarConeccion(connection);
            }
            
           
        
        
        }

        



        private Cartuchera<Util> MapearCartuchera(SqlDataReader infoLeida)
        {
            int id = infoLeida.GetInt32(0);
            int capacidad = infoLeida.GetInt32(1);
            float precioEvento = (float)infoLeida.GetDouble(2);
            string nombre = infoLeida.GetString(3); //<- si acepta nulos, validar lo qeu leo
                                                    //-> infoLeida.IsDBNull(x) ? null : infoLeida.GetString(x)
                                                    //se lee: si es null, devuelve nulo, sino lo es, devuelve string

            Cartuchera<Util> cartucheraLeida = new Cartuchera<Util>(id, precioEvento, capacidad, nombre);

            return cartucheraLeida;
        }

    }
}