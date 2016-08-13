using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("PESSOA_FISICA_CADASTRO", Schema = "DNAINFO")]
    public class InfoPessoaFisicaCadastro
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PESSOA_FISICA")]
        public long? Id { get; set; }
        [ForeignKey("Id")]
        public virtual InfoPessoaFisica InfoPessoaFisica { get; set; }

        [Column("NM_MAE")]
        [StringLength(100)]
        public string NomeMae { get; set; }

        [Column("NM_ABREVIADO")]
        [StringLength(80)]
        public string NomeAbreviado { get; set; }

        [Column("NM_PRIMEIRO")]
        [StringLength(60)]
        public string PrimeiroNome { get; set; }

        [Column("NM_ULTIMO")]
        [StringLength(60)]
        public string UltimoNome { get; set; }

        [Column("DT_NASCIMENTO")]
        public DateTime? DataNascimento { get; set; }

        [Column("NR_IDADE")]
        public byte? Idade { get; set; }

        [Column("SG_SEXO")]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Column("NR_RG")]
        [StringLength(12)]
        public string Rg { get; set; }

        [Column("DS_STATUS_RECEITA")]
        [StringLength(80)]
        public string StatusReceita { get; set; }

        [Column("NR_TITULO_ELEITOR")]
        [StringLength(20)]
        public string TituloEleitor { get; set; }

        [Required]
        [Column("IS_OBITO")]
        public bool? Obito { get; set; }

        [Column("DT_OBITO")]
        public DateTime? DataObito { get; set; }

        [Required]
        [Column("IS_POSSIVEL_OBITO")]
        public bool? PossivelObito { get; set; }

        [Column("DS_ESTADO_CIVIL")]
        [StringLength(80)]
        public string EstadoCivil { get; set; }

        [Column("ID_ORIGEM_DADOS")]
        public short? IdOrigemDados { get; set; }
        [ForeignKey("IdOrigemDados")]
        public virtual InfoOrigemDados InfoOrigemDados { get; set; }

        [Required]
        [Column("CD_TIPO_ORIGEM")]
        [StringLength(2)]
        public string CodigoTipoOrigem { get; set; }
        [ForeignKey("CodigoTipoOrigem")]
        public virtual InfoOrigemDados InfoOrigemDadosCodigo { get; set; }

        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        #endregion

        #region Construtor

        public InfoPessoaFisicaCadastro()
        {

        }

        #endregion
    }
}
