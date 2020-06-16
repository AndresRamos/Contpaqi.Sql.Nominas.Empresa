using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10048
    {
        [Key]
        public int IDContratante { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]
        [StringLength(100)]
        public string RazonSocial { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}