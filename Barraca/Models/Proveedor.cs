using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Proveedor : Contacto
    {
        
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        private string nombre;

        public new string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Proveedor(int pId, int pRut, string pNombre, string pDescripcion)
        {
            Id = pId;
            Rut = pRut;
            Nombre = pNombre;
            Descripcion = pDescripcion;

        }

        public Proveedor()
        {
        }
    }
}