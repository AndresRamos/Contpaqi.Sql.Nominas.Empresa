using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10021
    {
        [Key]
        [Column(Order = 0)]
        public int idtipoacumulado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string tipomovtoacumulado { get; set; }

        public DateTime? timestamp { get; set; }
    }
}