using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reserva
    {
        public Reserva(string fechaInicio, string fechaFin, string estadoDePago, int cantidadPersonas, string idReserva) 
        {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoDePago = estadoDePago;
            CantidadPersonas = cantidadPersonas;
            IdReserva = idReserva;
        }

        public Reserva() { }    
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string EstadoDePago { get; set; }
        public int CantidadPersonas { get; set; }
        public string IdReserva { get; set;  }
    }
}
