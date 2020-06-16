using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10022
    {
        [Key]
        public int idtipoincidencia { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(4)]
        public string mnemonico { get; set; }

        public bool derechosueldo { get; set; }

        public double? porcentajesueldo { get; set; }

        [StringLength(1)]
        public string tipoimss { get; set; }

        [StringLength(1)]
        public string tipoincidencia { get; set; }

        public bool derechoseptimodia { get; set; }

        public DateTime? timestamp { get; set; }

        public double? valorunidad { get; set; }
    }
}