using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Factura : CompraVenta
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}