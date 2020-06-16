using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10006
    {
        [Key]
        public int idpuesto { get; set; }

        public int? numeropuesto { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(600)]
        public string Detalle { get; set; }
    }
}