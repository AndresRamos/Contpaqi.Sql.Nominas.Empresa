using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10050
    {
        [Key]
        public int IDTabla { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}