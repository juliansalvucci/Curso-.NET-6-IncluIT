using Dapper;
using System.Data.SqlClient; //Es System no Microsoft

namespace ApiDapper.Models
{
    public class Data //Clase que interactúa con el ORN.
    {
        public List<Product> GetAllProduct()
        {
            using (var cnn = new SqlConnection(""))
            {
                cnn.Open();
                var query = "SELECT * FROM Prodcuts";
                var listProduct = cnn.Query<Product>(query).ToList();
                return listProduct;
            }
        }

        public Product GetProductById(int id)
        {
            using (var cnn = new SqlConnection(""))
            {
                cnn.Open();
                var query = "SELECT * FROM Prodcuts WHERE ProductId = @id";
                var product = cnn.QueryFirstOrDefault<Product>(query, new {id});
                return product;
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var cnn = new SqlConnection(""))
            {
                cnn.Open();
                var query = "SELECT * FROM Orders o INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";
                var listOrders = cnn.Query<Order>(query).ToList();
                return listOrders;
            }
        }

    }
}
