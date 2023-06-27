using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrmCarniceria;
using Entidades;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
     [TestFixture]
    public class CrudStockTests
    {
        [Test]
        public void ObtenerProductoPorId_ExistingId_ReturnsProducto()
        {
            // Arrange
            int id = 1;

            // Act
            Producto producto = CrudStock.ObtenerProductoPorId(id);

            // Assert
            Assert.IsNotNull(producto);
            // Asegúrate de agregar más aserciones según lo necesario para verificar los valores del producto retornado.
        }

        [Test]
        public void ObtenerProductoPorId_NonExistingId_ReturnsNull()
        {
            // Arrange
            int id = -1;

            // Act
            Producto producto = CrudStock.ObtenerProductoPorId(id);

            // Assert
            Assert.IsNull(producto);
        }

        [Test]
        public void Leer_ReturnsListOfProductos()
        {
            // Act
            var productos = CrudStock.Leer();

            // Assert
            Assert.IsNotNull(productos);
            // Asegúrate de agregar más aserciones según lo necesario para verificar los valores de la lista de productos.
        }

        [Test]
        public void Guardar_AddsNewProductoToDatabase()
        {
            // Arrange
            Producto producto = new Producto(eCarne.Vacio, 10, 5.99);

            // Act
            CrudStock.Guardar(producto);

            // Assert
            // Verifica si el producto se agregó correctamente a la base de datos.
            // Puedes realizar una consulta o utilizar otro método para verificarlo.
        }

        [Test]
        public void Modificar_UpdatesExistingProductoInDatabase()
        {
            // Arrange
            Producto producto = new Producto(eCarne.Asado, 10, 5.99);
            producto.id = 1;

            // Act
            CrudStock.Modificar(producto);

            // Assert
            // Verifica si el producto se actualizó correctamente en la base de datos.
            // Puedes realizar una consulta o utilizar otro método para verificarlo.
        }
    }
}