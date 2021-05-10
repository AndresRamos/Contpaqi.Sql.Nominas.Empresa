using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10052
    {
        [Key]
        public int IdCambioTipoPer { get; set; }

        public int IdEmpleado { get; set; }

        public DateTime FechaInicioAplicacion { get; set; }

        public DateTime FechaFinAplicacion { get; set; }

        public int IdTipoPeriodo { get; set; }

        public int IdCambioAnterior { get; set; }

        public bool Autorizado { get; set; }

        public bool Vigente { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}