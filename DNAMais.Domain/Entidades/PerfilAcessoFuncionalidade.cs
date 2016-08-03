using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("PERFIL_ACESSO_FUNCIONALIDADE", Schema = "DNASITE")]
    public class PerfilAcessoFuncionalidade
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Index("TS_DNASITE_INDEX")]
        [Column("ID_PERFIL_ACESSO_BACKOFFICE")]
        public byte? IdPerfilBackOffice { get; set; }
        [ForeignKey("IdPerfilBackOffice")]
        public virtual PerfilAcessoBackOffice PerfilAcessoBackOffice { get; set; }

        [Required]
        [Column("CD_FUNCIONALIDADE_BACKOFFICE")]
        [StringLength(15)]
        public string CodigoFuncionalidadeBackOffice;
        [ForeignKey("CodigoFuncionalidadeBackOffice")]
        public virtual FuncionalidadeBackOffice FuncionalidadeBackOffice { get; set; }

        #endregion

        #region Construtor

        public PerfilAcessoFuncionalidade()
        {

        }

        #endregion
    }
}
