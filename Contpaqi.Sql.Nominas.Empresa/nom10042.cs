using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10042
    {
        [Key]
        public int IdMovtoCredito { get; set; }

        public int IdTarjetaCredito { get; set; }

        public int IdEmpleado { get; set; }

        public int IdPeriodo { get; set; }

        public int IdConcepto { get; set; }

        public double? Importe { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}