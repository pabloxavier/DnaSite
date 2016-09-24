using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("TIPO_TELEFONE", Schema = "DNAINFO")]
    public class InfoTipoTelefone
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_TIPO_TELEFONE")]
        public byte? Id { get; set; }

        [Required]
        [Column("DS_TIPO_TELEFONE")]
        [StringLength(60)]
        public string Descricao { get; set; }

        [Required]
        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Required]
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        public virtual ICollection<InfoPessoaFisicaTelefone> InfosPessoasFisicasTelefones { get; set; }

        #endregion

        #region Construtor

        public InfoTipoTelefone()
        {
            InfosPessoasFisicasTelefones = new HashSet<InfoPessoaFisicaTelefone>();
        }

        #endregion
    }
}
