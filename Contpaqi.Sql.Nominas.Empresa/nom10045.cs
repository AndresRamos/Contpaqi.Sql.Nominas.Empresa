using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom10045
    {
        public int ID { get; set; }

        [StringLength(40)]
        public string GUIDRef { get; set; }

        [StringLength(60)]
        public string UUID { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}