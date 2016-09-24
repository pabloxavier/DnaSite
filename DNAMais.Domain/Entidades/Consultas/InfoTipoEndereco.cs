using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("TIPO_ENDERECO", Schema = "DNAINFO")]
    public class InfoTipoEndereco
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_TIPO_ENDERECO")]
        public byte? Id { get; set; }

        [Required]
        [Column("DS_TIPO_ENDERECO")]
        [StringLength(60)]
        public string Descricao { get; set; }

        [Required]
        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Required]
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        public virtual ICollection<InfoPessoaFisicaEndereco> InfosPessoasFisicasEnderecos { get; set; }

        #endregion

        #region Construtor

        public InfoTipoEndereco()
        {
            InfosPessoasFisicasEnderecos = new HashSet<InfoPessoaFisicaEndereco>();
        }

        #endregion
    }
}
