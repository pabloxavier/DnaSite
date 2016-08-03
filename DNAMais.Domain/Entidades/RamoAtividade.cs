using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("RAMO_ATIVIDADE", Schema = "DNASITE")]
    public class RamoAtividade
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_RAMO_ATIVIDADE")]
        public int? Id { get; set; }

        [Required]
        [Column("NM_RAMO_ATIVIDADE")]
        public string Nome { get; set; }

        [Required]
        [Column("DT_RAMO_ATIVIDADE")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_CADASTRO")]
        public int? IdUsuarioCadastro { get; set; }
        [ForeignKey("IdUsuarioCadastro")]
        public virtual UsuarioBackOffice UsuarioBackOffice { get; set; }

        public virtual ICollection<ClienteEmpresa> ClientesEmpresas { get; set; }

        #endregion

        #region Construtor

        public RamoAtividade()
        {
            ClientesEmpresas = new HashSet<ClienteEmpresa>();
        }

        #endregion
    }
}
