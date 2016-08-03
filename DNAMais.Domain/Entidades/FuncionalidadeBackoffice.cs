using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("FUNCIONALIDADE_BACKOFFICE", Schema = "DNASITE")]
    public class FuncionalidadeBackOffice
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CD_FUNCIONALIDADE_BACKOFFICE")]
        [Index("TS_DNASITE_INDEX")]
        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [Column("NM_FUNCIONALIDADE")]
        [StringLength(80)]
        public string Nome;

        #endregion

        #region Construtor

        public FuncionalidadeBackOffice()
        {

        }

        #endregion

    }
}
