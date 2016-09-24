using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("PESSOA_FISICA_EMAIL", Schema = "DNAINFO")]
    public class InfoPessoaFisicaEmail
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PESSOA_FISICA_EMAIL")]
        public long? Id { get; set; }

        [Required]
        [Column("ID_PESSOA_FISICA")]
        public long? IdPessoaFisica { get; set; }
        [ForeignKey("IdPessoaFisica")]
        public virtual InfoPessoaFisica InfoPessoaFisica { get; set; }

        [Required]
        [Column("DS_EMAIL")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
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

        [Required]
        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Required]
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        #endregion

        #region Construtor

        public InfoPessoaFisicaEmail()
        {

        }

        #endregion
    }
}
