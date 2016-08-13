using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("PESSOA_FISICA_TELEFONE", Schema = "DNAINFO")]
    public class InfoPessoaFisicaTelefone
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PESSOA_FISICA_TELEFONE")]
        public long? Id { get; set; }

        [Required]
        [Column("ID_PESSOA_FISICA")]
        public long? IdPessoaFisica { get; set; }
        [ForeignKey("IdPessoaFisica")]
        public virtual InfoPessoaFisica InfoPessoaFisica { get; set; }

        [Column("NR_DDD")]
        public byte? Ddd { get; set; }

        [Column("NR_TELEFONE")]
        public int? Telefone { get; set; }

        [Column("DS_EXTENSAO")]
        public int? Extensao { get; set; }

        [Required]
        [Column("ID_TIPO_TELEFONE")]
        public byte? IdTipoTelefone { get; set; }
        [ForeignKey("IdTipoTelefone")]
        public virtual InfoTipoTelefone InfoTipoTelefone { get; set; }

        [Column("ID_PESSOA_FISICA_ENDERECO")]
        public long? IdPessoaFisicaEndereco { get; set; }
        [ForeignKey("IdPessoaFisicaEndereco")]
        public virtual InfoPessoaFisicaEndereco InfoPessoaFisicaEndereco { get; set; }

        [Required]
        [Column("IS_PROCON")]
        public bool? Procon { get; set; }

        [Column("DT_CADASTRO_PROCON")]
        public DateTime? DataCadastroProcon { get; set; }

        [Column("DT_BLOQUEIO_PROCON")]
        public DateTime? DataBloqueioProcon { get; set; }

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

        public InfoPessoaFisicaTelefone()
        {

        }

        #endregion
    }
}
