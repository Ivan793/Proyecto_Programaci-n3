using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public Cliente(string nombre, string telefono, string idCliente)
        {
            Nombre = nombre;
            Telefono = telefono;
            IdCliente = idCliente;
        }

        public Cliente() { }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string IdCliente { get; set; }
    }
}
