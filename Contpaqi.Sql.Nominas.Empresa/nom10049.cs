using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10049
    {
        [Key]
        public int IDRelacion { get; set; }

        public int IDEmpleado { get; set; }

        public int IDContratante { get; set; }

        public double PorcentajeTiempo { get; set; }
    }
}