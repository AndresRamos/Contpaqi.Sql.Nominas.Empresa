using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class Nom10046
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFiniquito { get; set; }

        public int idPeriodo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEmpleado { get; set; }

        public DateTime FechaBaja { get; set; }

        [Required]
        [StringLength(100)]
        public string ParametrosGenerales { get; set; }

        [Required]
        [StringLength(200)]
        public string ConceptosCalculo { get; set; }

        public bool Calculado { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}