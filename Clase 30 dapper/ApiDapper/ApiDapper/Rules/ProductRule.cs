using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class ProductRule //Regla que toma la data que tomo La clase Data por medio del ORM, Esto es por si queremos cambiar de ORM, para la regla es transparente.
    {
        public List<Product> GetAllProdcuts()
        {
            var data = new Data();
            return data.GetAllProduct();
        }

        public Product GetProdcutById(int id)
        {
            var data = new Data();
            return data.GetProductById(id);
        }
    }
}
