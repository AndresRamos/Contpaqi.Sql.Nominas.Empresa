using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10030
    {
        [Key]
        public int idcategoria { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        [StringLength(1)]
        public string grupo { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public int? posicion { get; set; }

        public DateTime? timestamp { get; set; }

        public bool cpropia { get; set; }
    }
}