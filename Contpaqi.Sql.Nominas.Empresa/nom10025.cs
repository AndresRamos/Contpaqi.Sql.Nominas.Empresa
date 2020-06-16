using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10025
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idperiodo { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime fecha { get; set; }
    }
}