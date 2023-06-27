using NUnit.Framework;
using Entidades;
using Assert = NUnit.Framework.Assert;
using System.Data.SqlClient;

namespace PruebasUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verificar_Id_Coincide_Con_Datos()
        {
            
            int id = 1;
            Producto productoEsperado = new Producto(eCarne.Asado, 583, 1000);

            Producto productoObtenido = CrudStock.ObtenerProductoPorId(id);

            Assert.IsNotNull(productoObtenido);
            Assert.AreEqual(productoEsperado.TipoCarne, productoObtenido.TipoCarne);
            Assert.AreEqual(productoEsperado.Peso, productoObtenido.Peso);
            Assert.AreEqual(productoEsperado.PrecioPorKg, productoObtenido.PrecioPorKg);
        }

        [TestMethod]
        public void Guardar_UsuarioExistente_UsuarioGuardadoCorrectamente()
        {
            string email = "usuario1@sasha.com";
            string contrasenia = "123456";
            int tipoUsuario = 1;
            Usuario usuario = new Comprador(email, contrasenia, tipoUsuario);

            CrudUsuarios.Guardar(usuario);
           
        }
        [TestMethod]
        public void Borrar_VentaExistente_BorradoExitoso()
        {
            // Arrange
            int idVenta = 50;

            // Act
            CrudHistorialVentas.Borrar(idVenta);

            // Assert
            List<VentasHistorial> ventasObtenidas = CrudHistorialVentas.Leer();
            VentasHistorial ventaBorrada = ventasObtenidas.Find(v => v.Id == idVenta);
            Assert.IsNull(ventaBorrada);
        }


    }
}