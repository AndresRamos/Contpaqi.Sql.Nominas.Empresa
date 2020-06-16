using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10024
    {
        [Key]
        public int iddispfiscal { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(255)]
        public string ruta { get; set; }

        [StringLength(5)]
        public string fechainicio { get; set; }

        [StringLength(1)]
        public string frecuencia { get; set; }

        public bool activada { get; set; }

        public DateTime? timestamp { get; set; }
    }
}