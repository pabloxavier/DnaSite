using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("GRUPO_USUARIO_CLIENTE", Schema = "DNASITE")]
    public class GrupoUsuarioCliente
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_GRUPO_USUARIO_CLIENTE")]
        public int? Id { get; set; }

        [Required]
        [Column("ID_CLIENTE_EMPRESA")]
        public int? IdClienteEmpresa { get; set; }
        [ForeignKey("IdClienteEmpresa")]
        public virtual ClienteEmpresa ClienteEmpresa { get; set; }

        [Required]
        [Column("NM_GRUPO")]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [Column("DS_GRUPO")]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_BACKOFFICE_CADASTRO")]
        public int? IdUsuarioBackofficeCadastro { get; set; }
        [ForeignKey("IdUsuarioBackofficeCadastro")]
        public virtual UsuarioBackoffice UsuarioBackoffice { get; set; }

        [Required]
        [Column("ID_USUARIO_CLIENTE_CADASTRO")]
        public int? IdUsuarioClienteCadastro { get; set; }
        [ForeignKey("IdUsuarioClienteCadastro")]
        public virtual UsuarioCliente UsuarioCliente { get; set; }

        public virtual ICollection<UsuarioClienteGrupo> UsuariosClientesGrupos { get; set; }

        #endregion

        #region Construtor

        public GrupoUsuarioCliente()
        {

        }

        #endregion
    }
}
