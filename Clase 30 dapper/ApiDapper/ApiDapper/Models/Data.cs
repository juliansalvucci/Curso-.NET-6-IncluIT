using Dapper;
using System.Data.SqlClient; //Es System no Microsoft
using System.Diagnostics;

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

        /*
        public List<Order> GetAllOrders()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            stopWatch.Stop();
            var tiempo = stopWatch.ElapsedMilliseconds;
            using (var cnn = new SqlConnection(""))
            {
                cnn.Open();
                var q = "SELECT * FROM Orders o INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";
                var lookup = new Dictionary<int, Order>();

                cnn.Query<Order, OrderDetail, Order>(q,
                (o,d) =>
                {
                    if (!lookup.TryGetValue(o.OrderId, out Order order))
                    {
                        lookup.Add(o.OrderId, order = o);
                    }
                    if (order.Details == null)
                    {
                        order.Details = new List<OrderDetail>();
                    }
                    order.Details.Add(d);
                    return order;
                },
                splitOn: "OrderId").AsQueryable
            }
        }
        */

        public int DeleteOrderById(int orderId)
        {
            using (var cnn = new SqlConnection(""))
            {
                cnn.Open();
                var query = "SELECT * FROM Prodcuts WHERE ProductId = @id";
                var product = cnn.QueryFirstOrDefault<Product>(query, new { id });
                return product;
            }
        }

    }
}
