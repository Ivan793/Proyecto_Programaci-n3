using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Habitacion
    {
        public Habitacion(double tarifa, string estado, string tipoHabitacion, string idHabitación)
        {
            Tarifa = tarifa;
            Estado = estado;
            TipoHabitacion = tipoHabitacion;
            IdHabitación = idHabitación;
        }
        public  Habitacion() { }
        public double Tarifa { get; set; }
        public string Estado { get; set; }
        public string TipoHabitacion { get; set; }
        public string IdHabitación { get; set; }
    }
}
