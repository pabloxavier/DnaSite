using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("UF", Schema = "DNAINFO")]
    public class InfoUf
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("SG_UF")]
        [StringLength(2)]
        public string SiglaUf { get; set; }

        [Required]
        [Column("NM_UF")]
        [StringLength(60)]
        public string NomeUf { get; set; }

        [Required]
        [Column("DT_INCLUSAO")]
        public DateTime? DataInclusao { get; set; }

        [Required]
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        public virtual ICollection<InfoPessoaFisicaEndereco> InfosPessoasFisicasEnderecos { get; set; }

        #endregion

        #region Construtor

        public InfoUf()
        {
            InfosPessoasFisicasEnderecos = new HashSet<InfoPessoaFisicaEndereco>();
        }

        #endregion
    }
}
