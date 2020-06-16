using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10010
    {
        [Key]
        public int idmovtodyh { get; set; }

        public int? idperiodo { get; set; }

        public int? idempleado { get; set; }

        public int? idtipoincidencia { get; set; }

        public int? idtarjetaincapacidad { get; set; }

        public int? idtcontrolvacaciones { get; set; }

        public DateTime? fecha { get; set; }

        public double? valor { get; set; }

        public DateTime? timestamp { get; set; }
    }
}