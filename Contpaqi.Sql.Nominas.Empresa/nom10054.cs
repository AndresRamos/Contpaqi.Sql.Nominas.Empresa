using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10054
    {
        [Key]
        public int IdAviso { get; set; }

        [Required]
        [StringLength(11)]
        public string NRP { get; set; }

        [Required]
        [StringLength(11)]
        public string NSS { get; set; }

        [Required]
        [StringLength(13)]
        public string RFCTrabajador { get; set; }

        [Required]
        [StringLength(14)]
        public string FolioAviso { get; set; }

        [Required]
        [StringLength(10)]
        public string NumCredito { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoAviso { get; set; }

        public DateTime FechaNotLinea { get; set; }

        public DateTime FechaOtorgamiento { get; set; }

        public DateTime FechaCreaAviso { get; set; }

        [Required]
        [StringLength(11)]
        public string NSSUnificado { get; set; }

        [Required]
        [StringLength(3)]
        public string TipoCredito { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoDescuento { get; set; }

        public double FacDescuento { get; set; }

        public double MonDescuento { get; set; }

        [Required]
        [StringLength(3)]
        public string EstatusCredito { get; set; }

        [Required]
        [StringLength(18)]
        public string CURPTrabajador { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}