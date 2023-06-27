using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CrudStock
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;



    


        static CrudStock()
        {
            connectionString = @"Server = DESKTOP-548T647; Database = Productos; Trusted_Connection = True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear(); // limpiar 
                command.CommandText = "SELECT * FROM TableStockNueva WHERE ID = @id";
                command.Parameters.AddWithValue("id", id);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    eCarne carne = (eCarne)Enum.Parse(typeof(eCarne), dataReader["corte"].ToString());
                    int kilos = Convert.ToInt32(dataReader["peso"]);
                    double precio = Convert.ToDouble(dataReader["precio"]);

                    return new Producto(carne, kilos, precio);
                }

                return null; // no fue encontrado
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

        public static List<Producto> Leer()
        {
            List<Producto> miProducto = new List<Producto>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM TableStockNueva";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    eCarne carne = (eCarne)Enum.Parse(typeof(eCarne), dataReader["corte"].ToString());
                    int kilos = Convert.ToInt32(dataReader["peso"]);
                    double precio = Convert.ToDouble(dataReader["precio"]);

                    miProducto.Add(new Producto(carne, kilos, precio));
                }

                return miProducto;
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



        public static void Guardar(Producto miProducto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO TableStockNueva (corte,peso,precio)  VALUES(@corte,@peso,@precio)";
                command.Parameters.AddWithValue("corte", miProducto.TipoCarne);
                command.Parameters.AddWithValue("peso", miProducto.Peso);
                command.Parameters.AddWithValue("precio", miProducto.PrecioPorKg);




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


        public static void Modificar(Producto miProducto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE TableStockNueva SET peso = @peso,precio = @precio WHERE ID= @ID  ";
                command.Parameters.AddWithValue("peso", miProducto.Peso);
                command.Parameters.AddWithValue("precio", miProducto.PrecioPorKg);
                command.Parameters.AddWithValue("id", miProducto.id);


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
