using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("ORIGEM_DADOS", Schema = "DNAINFO")]
    public class InfoOrigemDados
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_ORIGEM_DADOS", Order = 1)]
        public short? Id { get; set; }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CD_TIPO_ORIGEM", Order = 2)]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        [Column("NM_ORIGEM_DADOS")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column("DS_ORIGEM_DADOS")]
        [StringLength(150)]
        public string Descricao { get; set; }

        [Column("NM_ARQUIVO")]
        [StringLength(150)]
        public string NomeArquivo { get; set; }

        [Required]
        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Required]
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        [Column("DIRETORIO")]
        [StringLength(400)]
        public string Diretorio { get; set; }

        public virtual ICollection<InfoPessoaFisicaCadastro> InfosPessoasFisicasCadastros { get; set; }
        public virtual ICollection<InfoOrigemDados> InfosOrigensDados { get; set; }
        public virtual ICollection<InfoPessoaFisicaEndereco> InfosPessoasFisicasEnderecos { get; set; }
        public virtual ICollection<InfoPessoaFisicaTelefone> InfosPessoasFisicasTelefones { get; set; }

        #endregion

        #region Construtor

        public InfoOrigemDados()
        {
            InfosPessoasFisicasCadastros = new HashSet<InfoPessoaFisicaCadastro>();
            InfosOrigensDados = new HashSet<InfoOrigemDados>();
            InfosPessoasFisicasEnderecos = new HashSet<InfoPessoaFisicaEndereco>();
            InfosPessoasFisicasTelefones = new HashSet<InfoPessoaFisicaTelefone>();
        }

        #endregion
    }
}
