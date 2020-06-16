using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10020
    {
        [Key]
        public int idbajareingreso { get; set; }

        public int? idempleado { get; set; }

        [StringLength(1)]
        public string clavebajareingreso { get; set; }

        public DateTime? fecha { get; set; }

        public int? cidperiodo { get; set; }

        public int? cidtipoperiodo { get; set; }
    }
}