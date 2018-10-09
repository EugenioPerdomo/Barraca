using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Contacto
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


    }
}