using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10028
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numerotabla { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numerocolumna { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(1)]
        public string tipocolumna { get; set; }
    }
}