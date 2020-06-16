using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Empresa
{
    public class nom100xx
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idempleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idtipoperiodo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cidperiodo { get; set; }

        public int? iddepartamento { get; set; }

        public int? idpuesto { get; set; }

        public int? idturno { get; set; }

        [StringLength(1)]
        public string estadocivil { get; set; }

        public int? umf { get; set; }

        [StringLength(20)]
        public string cuentapagoelectronico { get; set; }

        [StringLength(50)]
        public string sucursalpagoelectronico { get; set; }

        [StringLength(3)]
        public string bancopagoelectronico { get; set; }

        [StringLength(1)]
        public string estadoempleado { get; set; }

        public double? sueldodiario { get; set; }

        public DateTime? fechasueldodiario { get; set; }

        public double? sueldovariable { get; set; }

        public DateTime? fechasueldovariable { get; set; }

        public double? sueldopromedio { get; set; }

        public DateTime? fechasueldopromedio { get; set; }

        public double? sueldointegrado { get; set; }

        public DateTime? fechasueldointegrado { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool calculado { get; set; }

        public bool? afectado { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool calculadoextraordinario { get; set; }

        public bool? afectadoextraordinario { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool interfazcheqpaqw { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool modificacionneto { get; set; }

        public DateTime? fechaalta { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        [StringLength(2)]
        public string tipocontrato { get; set; }

        [StringLength(1)]
        public string basecotizacionimss { get; set; }

        [StringLength(1)]
        public string tipoempleado { get; set; }

        [StringLength(1)]
        public string basepago { get; set; }

        [StringLength(3)]
        public string formapago { get; set; }

        [StringLength(1)]
        public string zonasalario { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool modificacionsalarioimss { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool altaimss { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool bajaimss { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool cambiocotizacionimss { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        public int? codigopostal { get; set; }

        [StringLength(60)]
        public string direccion { get; set; }

        [StringLength(60)]
        public string poblacion { get; set; }

        [StringLength(3)]
        public string estado { get; set; }

        [StringLength(50)]
        public string numeroafore { get; set; }

        public DateTime? fechabaja { get; set; }

        [StringLength(60)]
        public string causabaja { get; set; }

        public double? sueldobaseliquidacion { get; set; }

        [StringLength(80)]
        public string campoextra1 { get; set; }

        [StringLength(80)]
        public string campoextra2 { get; set; }

        [StringLength(80)]
        public string campoextra3 { get; set; }

        public DateTime? fechareingreso { get; set; }

        public int? ajustealneto { get; set; }

        public DateTime? timestamp { get; set; }

        public int? cidregistropatronal { get; set; }

        [StringLength(4)]
        public string cestadoempleadoperiodo { get; set; }

        public double? ccampoextranumerico1 { get; set; }

        public double? ccampoextranumerico2 { get; set; }

        public double? ccampoextranumerico3 { get; set; }

        public double? ccampoextranumerico4 { get; set; }

        public double? ccampoextranumerico5 { get; set; }

        public double? cdiastrabajados { get; set; }

        public double? cdiaspagados { get; set; }

        public double? cdiascotizados { get; set; }

        public double? cdiasausencia { get; set; }

        public double? cdiasincapacidades { get; set; }

        public double? cdiasvacaciones { get; set; }

        public double? cdiaspropseptimos { get; set; }

        public double? chorasextras1 { get; set; }

        public double? chorasextras2 { get; set; }

        public double? chorasextras3 { get; set; }

        public DateTime? cfechasueldomixto { get; set; }

        public double? csueldomixto { get; set; }

        public DateTime? cfechacorte { get; set; }

        [StringLength(60)]
        public string CorreoElectronico { get; set; }

        [StringLength(30)]
        public string ClabeInterbancaria { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoPrestacion { get; set; }
    }
}