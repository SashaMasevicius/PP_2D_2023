using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CrudUsuarios
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static CrudUsuarios()
        {
            connectionString = @"Server = DESKTOP-548T647; Database = Usuario; Trusted_Connection = True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM TableUsuarios";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string email = dataReader["usuario"].ToString();
                    string contrasenia = dataReader["contrasena"].ToString();
                    int tipoUsuario = Convert.ToInt32(dataReader["tipodeusuario"]);

                    if (tipoUsuario == 0)
                    {
                        listaUsuarios.Add(new Comprador(email, contrasenia));
                    }
                    else if (tipoUsuario == 1)
                    {
                        listaUsuarios.Add(new Vendedor(email, contrasenia));
                    }
                }

                return listaUsuarios;
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

        public static void Guardar(Usuario user)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO TableUsuarios (usuario,contrasena,tipodeusuario)  VALUES(@usuario,@contrasena,@tipodeusuario)";
                command.Parameters.AddWithValue("usuario", user.Email);
                command.Parameters.AddWithValue("contrasena", user.Contrasenia);
                command.Parameters.AddWithValue("tipodeusuario", user.TipoDeUsuario);

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
