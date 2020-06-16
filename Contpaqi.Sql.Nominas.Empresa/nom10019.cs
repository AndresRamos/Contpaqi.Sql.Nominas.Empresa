using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10019
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idempleado { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string tiposueldo { get; set; }

        public double? sueldo { get; set; }

        public int? cidperiodo { get; set; }

        public int? cidtipoperiodo { get; set; }
    }
}