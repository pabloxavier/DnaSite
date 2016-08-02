using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("PRODUTO", Schema = "DNASITE")]
    public class Produto
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [Column("CD_PRODUTO")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [Column("NM_PRODUTO")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column("DS_PRODUTO")]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [Column("CD_CATEGORIA_PRODUTO")]
        [StringLength(10)]
        public string CodigoCategoria { get; set; }
        [ForeignKey("CodigoCategoria")]
        public virtual CategoriaProduto CategoriaProduto { get; set; }

        public virtual IEnumerable<ItemProduto> ItensProdutos { get; set; }
        public virtual IEnumerable<ContratoEmpresaProduto> ContratosEmpresasProdutos { get; set; }

        #endregion

        #region Construtor

        public Produto()
        {

        }

        #endregion
    }
}
