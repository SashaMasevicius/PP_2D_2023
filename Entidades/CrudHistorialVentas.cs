using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CrudHistorialVentas
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static CrudHistorialVentas()
        {
            connectionString = @"Server = DESKTOP-548T647; Database = VentaTablas; Trusted_Connection = True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<VentasHistorial> Leer()
        {
            List<VentasHistorial> listaVentas = new List<VentasHistorial>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM tablaVentasCarniceria";
                SqlDataReader dataReader = command.ExecuteReader();

               
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["id"]);
                    int kilos = Convert.ToInt32(dataReader["kilos"]);
                    double totalventa = Convert.ToDouble(dataReader["totalventa"]);

                    listaVentas.Add(new VentasHistorial(id, dataReader["comprador"].ToString(), dataReader["corte"].ToString(), kilos, totalventa));

     
                }

                return listaVentas;
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



        public static void Guardar(VentasHistorial hist)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO tablaVentasCarniceria (comprador,corte,kilos,totalventa)  VALUES(@comprador,@corte,@kilos,@totalventa)";
                command.Parameters.AddWithValue("comprador", hist.Comprador);
                command.Parameters.AddWithValue("corte", hist.Corte);
                command.Parameters.AddWithValue("kilos", hist.Kilos);
                command.Parameters.AddWithValue("totalventa", hist.TotalVenta);




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


        public static void Modificar(VentasHistorial ventasHist)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE tablaVentasCarniceria SET comprador = @comprador , corte = @corte, kilos = @kilos,totalventa = @totalventa WHERE ID= @ID  ";
                command.Parameters.AddWithValue("comprador", ventasHist.Comprador);
                command.Parameters.AddWithValue("corte", ventasHist.Corte);
                command.Parameters.AddWithValue("kilos", ventasHist.Kilos);
                command.Parameters.AddWithValue("totalventa", ventasHist.TotalVenta);



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
        public static void Borrar(int id)
        {
            try
            {
                command.Parameters.Clear(); 
                connection.Open();

                //para evitar inyecccion SQL:
                command.CommandText = $"DELETE FROM tablaVentasCarniceria WHERE id = @id";
                command.Parameters.AddWithValue("id", id);


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
