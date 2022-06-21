﻿using BilleteraInterfaces.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraInterfaces.Version_2
{
    public class BilleteraIterfaceada : IBilletera 
    {
        private int[,] billetes = new int[7, 2]; 

        public BilleteraIterfaceada()
        {
            billetes[0,1] = 10;
            billetes[1,1] = 20;
            billetes[2,1] = 30;
            billetes[3, 1] = 50;
            billetes[4, 1] = 100;
            billetes[5, 1] = 200;
            billetes[6, 1] = 500;
            billetes[7, 1] = 1000;
        }

        public int BilletesDe10 { get { return billetes[0, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe20 { get { return billetes[1, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe50 { get { return billetes[2, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe100 { get { return billetes[3, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe200 { get { return billetes[4, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe500 { get { return billetes[5, 0]; } set { billetes[0, 0] = value; } }
        public int BilletesDe1000 { get { return billetes[6, 0]; } set { billetes[0, 0] = value; } }

        public decimal total()
        {
            decimal total = 0;

            for(int i = 0; i < billetes.Length; i++)
            {
                total += billetes[i,1] * billetes[i,0];
            }

            return total;
        }

        public IBilletera combinar(IBilletera b)
        {
            var nueva = new BilleteraIterfaceada();

            nueva.BilletesDe10 = BilletesDe10 + b.BilletesDe10;
            nueva.BilletesDe20 = BilletesDe20 + b.BilletesDe20;
            nueva.BilletesDe50 = BilletesDe50 + b.BilletesDe50;
            nueva.BilletesDe100 = BilletesDe100 + b.BilletesDe100;
            nueva.BilletesDe200 = BilletesDe200 + b.BilletesDe200;
            nueva.BilletesDe500 = BilletesDe500 + b.BilletesDe500;
            nueva.BilletesDe1000 = BilletesDe1000 + b.BilletesDe1000;

            vaciar();

            b.BilletesDe10 = 0;
            b.BilletesDe20 = 0;
            b.BilletesDe50 = 0;
            b.BilletesDe100 = 0;
            b.BilletesDe200 = 0;
            b.BilletesDe500 = 0;
            b.BilletesDe1000 = 0;


            return nueva;
        }

        public void vaciar()
        {
            for(int i = 0; i < billetes.Length; i++)
            {
                billetes[i, 0] = 0;
            }
        }
    }
}

