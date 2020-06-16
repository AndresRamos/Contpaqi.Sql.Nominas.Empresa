using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10027
    {
        [Key]
        public int numerotabla { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public DateTime? timestamp { get; set; }
    }
}