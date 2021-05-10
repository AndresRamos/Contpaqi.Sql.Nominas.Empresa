using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10055
    {
        [Key]
        public int IdModificacion { get; set; }

        public double Descuento { get; set; }

        public DateTime FechaEntradaEnVigor { get; set; }

        public byte TipoModificacion { get; set; }

        public bool RegistroActivo { get; set; }
    }
}