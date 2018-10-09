using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Articulo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private double precioCompra;

        public double PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        private double precioVenta;

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        private int iva;

        public int Iva
        {
            get { return iva; }
            set { iva = value; }
        }

    }
}