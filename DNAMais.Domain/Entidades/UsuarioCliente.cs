using DNAMais.Domain.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("USUARIO_CLIENTE", Schema = "DNASITE")]
    [SequenceOracle("SQ_USUARIO_CLIENTE")]
    public class UsuarioCliente
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_USUARIO_CLIENTE")]
        public int? Id { get; set; }

        [Required]
        [Column("ID_CLIENTE_EMPRESA")]
        public int? IdClienteEmpresa { get; set; }
        [ForeignKey("IdClienteEmpresa")]
        public virtual ClienteEmpresa ClienteEmpresa { get; set; }

        [Required]
        [Column("DS_LOGIN")]
        public string Login { get; set; }

        [Required]
        [Column("DS_SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("NR_CPF")]
        public string Cpf { get; set; }

        [Required]
        [Column("DS_EMAIL")]
        public string Email { get; set; }

        [Required]
        [Column("IS_MASTER")]
        public bool? Master { get; set; }

        [Required]
        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_BACKOFFICE_CADASTRO")]
        public int? IdUsuarioBackOfficeCadastro { get; set; }
        [ForeignKey("IdUsuarioBackOfficeCadastro")]
        public virtual UsuarioBackOffice UsuarioBackOffice { get; set; }

        [Required]
        [Column("ID_USUARIO_CLIENTE_CADASTRO")]
        public int? IdUsuarioClienteCadastro { get; set; }

        //Verificar como efetuar o relacionamento
        //(Foreign Key referenciando a própria classe/tabela e pluralização)

        [ForeignKey("IdUsuarioClienteCadastro")]
        public virtual UsuarioCliente UsuarioClienteCadastro { get; set; }

        public virtual ICollection<UsuarioCliente> UsuariosCadastrados { get; set; }
        public virtual ICollection<UsuarioClientePerfil> UsuariosClientesPerfis { get; set; }
        public virtual ICollection<GrupoUsuarioCliente> GruposUsuariosClientes { get; set; }
        public virtual ICollection<UsuarioClienteGrupo> UsuariosClientesGrupos { get; set; }
        public virtual ICollection<TransacaoConsulta> TransacoesConsultas { get; set; }
        public virtual ICollection<SolicitacaoContagem> SolicitacoesContagens { get; set; }

        #endregion

        #region Construtor

        public UsuarioCliente()
        {
            UsuariosCadastrados = new HashSet<UsuarioCliente>();
            UsuariosClientesPerfis = new HashSet<UsuarioClientePerfil>();
            GruposUsuariosClientes = new HashSet<GrupoUsuarioCliente>();
            UsuariosClientesGrupos = new HashSet<UsuarioClienteGrupo>();
            TransacoesConsultas = new HashSet<TransacaoConsulta>();
            SolicitacoesContagens = new HashSet<SolicitacaoContagem>();
        }

        #endregion
    }
}
