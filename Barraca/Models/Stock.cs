using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Stock : Articulo
    {

        private int stockActual;

        public int StockActual
        {
            get { return stockActual ; }
            set { stockActual = value; }
        }

        private int stockMinimo;

        public int StockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }

        public Stock()
        {

        }

        public Stock(int pId, int pStockActual, int pStockMinimo)
        {
            Id = pId;
            StockActual = pStockActual;
            StockMinimo = pStockMinimo;
        }
    }
}