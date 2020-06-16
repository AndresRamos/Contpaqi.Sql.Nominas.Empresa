using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10033
    {
        [Key]
        public int idmodelo { get; set; }

        [StringLength(255)]
        public string archivo { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }
    }
}