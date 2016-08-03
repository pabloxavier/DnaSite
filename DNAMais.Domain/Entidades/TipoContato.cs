using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("TIPO_CONTATO", Schema = "DNASITE")]
    public class TipoContato
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_TIPO_CONTATO")]
        public int? Id { get; set; }

        [Required]
        [Column("NM_TIPO_CONTATO")]
        [StringLength(20)]
        public string Nome { get; set; }

        [Required]
        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_CADASTRO")]
        public int? IdUsuarioCadastro { get; set; }
        [ForeignKey("IdUsuarioCadastro")]
        public virtual UsuarioBackOffice UsuarioBackOffice { get; set; }

        public virtual ICollection<ClienteEmpresaContato> ClientesEmpresasContatos { get; set; }

        #endregion

        #region Construtor

        public TipoContato()
        {
            ClientesEmpresasContatos = new HashSet<ClienteEmpresaContato>();
        }

        #endregion
    }
}
