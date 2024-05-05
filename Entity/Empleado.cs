using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        public Empleado(string nombre, string cargo, string idEmpleado) 
        {
            Nombre = nombre;
            Cargo = cargo;
            IdEmpleado = idEmpleado;
        }
        public Empleado() { }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string IdEmpleado { get; set; }
    }
}
