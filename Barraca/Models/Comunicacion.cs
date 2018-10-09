using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barraca.Models
{
    public class Comunicacion : Proveedor
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string tipoDeContacto;

        public string TipodeContacto
        {
            get { return tipoDeContacto; }
            set { tipoDeContacto = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

    }
}