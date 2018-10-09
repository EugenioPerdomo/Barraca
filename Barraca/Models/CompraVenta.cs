using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class CompraVenta : Proveedor
    {

        private int id;

        public new int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int articulo;

        public int Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public CompraVenta()
        {

        }

        public CompraVenta(int pId, DateTime pFecha, int pArticulo)
        {
            Id = pId;
       
            Fecha = pFecha;
         
            Articulo = pArticulo;
       
        }
    }
}