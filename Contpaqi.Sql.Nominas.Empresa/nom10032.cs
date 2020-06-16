using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10032
    {
        [Key]
        public int idturno { get; set; }

        public int? numeroturno { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public double? numerohoras { get; set; }

        public DateTime? timestamp { get; set; }

        [Required]
        [StringLength(3)]
        public string TipoJornada { get; set; }
    }
}