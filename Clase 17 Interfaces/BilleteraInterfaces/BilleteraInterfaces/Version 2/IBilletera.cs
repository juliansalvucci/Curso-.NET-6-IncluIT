using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraInterfaces.Version_2
{
    public interface IBilletera
    {
        int BilletesDe10 { get; set; }
        int BilletesDe20 { get; set; }
        int BilletesDe50 { get; set; }
        int BilletesDe100 { get; set; }
        int BilletesDe200 { get; set; }
        int BilletesDe500 { get; set; }
        int BilletesDe1000 { get; set; }

        IBilletera combinar(IBilletera b);
        decimal total();

    }
}
