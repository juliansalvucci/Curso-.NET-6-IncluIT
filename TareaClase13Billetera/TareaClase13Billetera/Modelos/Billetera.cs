using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase13Billetera.Modelos
{
    public class Billetera
    {
        //Propiedades.
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        //Método para obtener el total.
        public decimal Total()
        {
            return BilletesDe10 + BilletesDe20 + BilletesDe50 + BilletesDe100 + BilletesDe200 + BilletesDe500 + BilletesDe1000;
        }

        //Método para combinar 2 billeteras.
        public Billetera Combinar(Billetera otraBilletera)
        {
            var nuevaBilletera = new Billetera();

            nuevaBilletera.BilletesDe10 = BilletesDe10 + otraBilletera.BilletesDe10;

            nuevaBilletera.BilletesDe20 = BilletesDe20 + otraBilletera.BilletesDe20;

            nuevaBilletera.BilletesDe50 = BilletesDe50 + otraBilletera.BilletesDe50;

            nuevaBilletera.BilletesDe100 = BilletesDe100 + otraBilletera.BilletesDe100;

            nuevaBilletera.BilletesDe200 = BilletesDe200 + otraBilletera.BilletesDe200;

            nuevaBilletera.BilletesDe500 = BilletesDe500 + otraBilletera.BilletesDe500;

            nuevaBilletera.BilletesDe1000 = BilletesDe1000 + otraBilletera.BilletesDe1000;

            //Vacio billetera actual
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;

            //Vacio la otra billetera
            otraBilletera.BilletesDe10 = 0;
            otraBilletera.BilletesDe20 = 0;
            otraBilletera.BilletesDe50 = 0;
            otraBilletera.BilletesDe100 = 0;
            otraBilletera.BilletesDe200 = 0;
            otraBilletera.BilletesDe500 = 0;
            otraBilletera.BilletesDe1000 = 0;
            
            //Devuelvo la nueva billetera
            return nuevaBilletera;
        }
    }
}
