using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CrudNuevosPrecios
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static CrudNuevosPrecios()
        {
            connectionString = @"Server = DESKTOP-548T647; Database = HistorialPrecios; Trusted_Connection = True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<HistorialPrecios> Leer()
        {
            List<HistorialPrecios> historial = new List<HistorialPrecios>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM TablaPrecios";
                SqlDataReader dataReader = command.ExecuteReader();

                // mientras lea sigue leyebdo
                while (dataReader.Read())
                {
                    // int id = Convert.ToInt32(dataReader["id"]);
                    DateTime fechaActual = DateTime.Now;
                    decimal nuevoPrecio = Convert.ToInt32(dataReader["NuevoPrecio"]);
                    historial.Add(new HistorialPrecios(fechaActual, dataReader["Corte"].ToString(), nuevoPrecio));

                }

                return historial;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void Guardar(HistorialPrecios historial)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();


                //para evitar inyecccion SQL:
                command.CommandText = $"INSERT INTO TablaPrecios (fecha,corte,nuevoprecio)  VALUES(@fecha,@corte,@nuevoprecio)";
                command.Parameters.AddWithValue("fecha", historial.Fecha);
                command.Parameters.AddWithValue("corte", historial.CorteDeCarne);
                command.Parameters.AddWithValue("nuevoprecio", historial.NuevoPrecio);
                command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
