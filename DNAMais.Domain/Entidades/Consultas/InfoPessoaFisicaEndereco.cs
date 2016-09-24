using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("PESSOA_FISICA_ENDERECO", Schema = "DNAINFO")]
    public class InfoPessoaFisicaEndereco
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PESSOA_FISICA_ENDERECO")]
        public long? Id { get; set; }

        [Required]
        [Column("ID_PESSOA_FISICA")]
        public long? IdPessoaFisica { get; set; }
        [ForeignKey("IdPessoaFisica")]
        public virtual InfoPessoaFisica InfoPessoaFisica { get; set; }

        [Column("DS_TIPO_LOGRADOURO")]
        [StringLength(20)]
        public string TipoLogradouro { get; set; }

        [Column("DS_LOGRADOURO")]
        [StringLength(100)]
        public string Logradouro { get; set; }

        [Column("NR_LOGRADOURO")]
        [StringLength(20)]
        public string NumeroLogradouro { get; set; }

        [Column("DS_COMPLEMENTO")]
        [StringLength(80)]
        public string Complemento { get; set; }

        [Column("NM_BAIRRO")]
        [StringLength(80)]
        public string Bairro { get; set; }

        [Column("NM_CIDADE")]
        [StringLength(80)]
        public string Cidade { get; set; }

        [Column("SG_UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [ForeignKey("Uf")]
        public virtual InfoUf InfoUf { get; set; }

        [Column("NR_CEP")]
        [StringLength(8)]
        public string Cep { get; set; }

        [Required]
        [Column("ID_TIPO_ENDERECO")]
        public byte? IdTipoEndereco { get; set; }
        [ForeignKey("IdTipoEndereco")]
        public virtual InfoTipoEndereco InfoTipoEndereco { get; set; }

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

        public virtual ICollection<InfoPessoaFisicaTelefone> InfosPessoasFisicasTelefones { get; set; }

        #endregion

        #region Construtor

        public InfoPessoaFisicaEndereco()
        {
            InfosPessoasFisicasTelefones = new HashSet<InfoPessoaFisicaTelefone>();
        }

        #endregion
    }
}
