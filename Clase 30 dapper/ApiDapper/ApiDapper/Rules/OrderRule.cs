using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class OrderRule
    {
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            try
            {
                var data = new Data();
                var cant = data.DeleteOrderById(orderId).c;
                return new RespuestaDelete()
                {
                    Cantidad = cant,
                    Result = true,
                    Error = ""
                };
            }
            catch (Exception ex)
            {
                return new RespuestaDelete()
                {
                    Cantidad = 0,
                    Result = false,
                    Error = ex.Message
                };
            }

        }
    }
}
