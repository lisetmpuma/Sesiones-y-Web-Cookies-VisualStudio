﻿
/*using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;        // Agregar para trabajar con SQL Server

namespace ProjectService
{
    public class Service1 : IService1
    {
        public IList<string> getCiudades()
        {
            IList<string> ciudades = new List<string>();     
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=DBWeb1;Integrated Security=True";       // Cadena de conexión para conectar a la base de datos
            
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {                 
                    connection.Open();                                                                      // Abrir la conexión       
                    string query = "SELECT Ciudad FROM DataCiudad";                                         // Consulta SQL para obtener los nombres de las ciudades desde la tabla DataCiudad

                   
                    using (SqlCommand command = new SqlCommand(query, connection))                           // Ejecutar la consulta SQL
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {                          
                            while (reader.Read())                                                              // Lee los resultados de la consulta y almacenarlos en la lista ciudades
                            {
                                string nombreCiudad = reader["Ciudad"].ToString();
                                ciudades.Add(nombreCiudad);
                            }
                        }
                    }
                }

                catch (Exception ex)                                                                            // En caso de error al conectar a la base de datos o ejecutar la consulta
                {  Console.WriteLine("Error al obtener ciudades de la base de datos: " + ex.Message); }

                finally
                { connection.Close(); }                                                                        // Cerrar la conexión después de usarla
            }
            return ciudades;
        }
    }
}
