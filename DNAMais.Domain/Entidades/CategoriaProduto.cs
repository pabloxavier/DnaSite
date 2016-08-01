using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("CATEGORIA_PRODUTO", Schema = "DNASITE")]
    public class CategoriaProduto
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [Column("CD_CATEGORIA_PRODUTO")]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [Column("NM_CATEGORIA_PRODUTO")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column("CD_TIPO_PRECIFICACAO")]
        public short? CodigoPrecificacao { get; set; }
        [ForeignKey("CodigoPrecificacao")]
        public virtual TipoPrecificacao CodigoTipoPrecificacao { get; set; }

        public virtual ICollection<CategoriaProdutoFaixa> CategoriasFaixas { get; set; }
        public virtual ICollection<CategoriaProdutoFaixaLog> LogCategoriasFaixas { get; set; }

        #endregion

        #region Construtor

        public CategoriaProduto()
        {

        }

        #endregion
    }
}
