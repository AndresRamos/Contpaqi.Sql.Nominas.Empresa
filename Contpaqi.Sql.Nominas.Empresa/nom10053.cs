using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10053
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idempleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cidperiodo { get; set; }

        public bool cdiastrabajadosreportado { get; set; }

        public bool cdiaspagadosreportado { get; set; }

        public bool cdiascotizadosreportado { get; set; }

        public bool cdiaspropseptimosreportado { get; set; }

        public DateTime timestamp { get; set; }
    }
}