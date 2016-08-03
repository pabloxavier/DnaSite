using DNAMais.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain
{
    [Table("USUARIO_BACKOFFICE", Schema = "DNASITE")]
    public class UsuarioBackOffice
    {
        #region Propriedades Públicas

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Column("ID_USUARIO_BACKOFFICE")]
        [Index("TS_DNASITE_INDEX")]
        public int? Id { get; set; }

        [Required]
        [Index("TS_DNASITE_INDEX", 1, IsUnique = true)]
        [Column("NM_USUARIO")]
        public string Nome { get; set; }

        [Required]
        [Index("TS_DNASITE_INDEX", 2, IsUnique = true)]
        [Column("DS_EMAIL")]
        public string Email { get; set; }

        [Required]
        [Column("DS_LOGIN")]
        public string Login { get; set; }

        [Required]
        [Column("DS_SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("DT_CRIACAO")]
        public DateTime? DataCriacao { get; set; }

        [Required]
        [Column("IS_ADMIN")]
        public byte? Admin { get; set; }

        [Column("ID_PERFIL_ACESSO_BACKOFFICE")]
        public byte? IdPerfil { get; set; }

        public virtual ICollection<MensagemContato> MensagensContatos { get; set; }
        public virtual ICollection<UsuarioBackOffice> UsuariosBackOffice { get; set; }
        public virtual ICollection<ClienteEmpresa> ClientesEmpresas { get; set; }
        public virtual ICollection<TipoEndereco> TiposEnderecos { get; set; }
        public virtual ICollection<ClienteEmpresaEndereco> ClientesEmpresasEnderecos { get; set; }
        public virtual ICollection<TipoContato> TiposContatos { get; set; }
        public virtual ICollection<ClienteEmpresaContato> ClientesEmpresasContatos { get; set; }
        public virtual ICollection<ClienteEmpresaContatoFone> ClientesEmpresasContatosFones { get; set; }
        public virtual ICollection<ClienteEmpresaContatoEmail> ClientesEmpresasContatosEmails { get; set; }
        public virtual ICollection<ContratoEmpresa> ContratosEmpresas { get; set; }
        public virtual ICollection<UsuarioCliente> UsuariosClientes { get; set; }
        public virtual ICollection<UsuarioClientePerfil> UsuariosClientesPerfis { get; set; }
        public virtual ICollection<GrupoUsuarioCliente> GruposUsuariosClientes { get; set; }
        public virtual ICollection<UsuarioClienteGrupo> UsuariosClientesGrupos { get; set; }

        #endregion

        #region Construtor

        public UsuarioBackOffice()
        {
            MensagensContatos = new HashSet<MensagemContato>();
            UsuariosBackOffice = new HashSet<UsuarioBackOffice>();
            ClientesEmpresas = new HashSet<ClienteEmpresa>();
            TiposEnderecos = new HashSet<TipoEndereco>();
            ClientesEmpresasEnderecos = new HashSet<ClienteEmpresaEndereco>();
            TiposContatos = new HashSet<TipoContato>();
            ClientesEmpresasContatos = new HashSet<ClienteEmpresaContato>();
            ClientesEmpresasContatosFones = new HashSet<ClienteEmpresaContatoFone>();
            ClientesEmpresasContatosEmails = new HashSet<ClienteEmpresaContatoEmail>();
            ContratosEmpresas = new HashSet<ContratoEmpresa>();
            UsuariosClientes = new HashSet<UsuarioCliente>();
            UsuariosClientesPerfis = new HashSet<UsuarioClientePerfil>();
            GruposUsuariosClientes = new HashSet<GrupoUsuarioCliente>();
            UsuariosClientesGrupos = new HashSet<UsuarioClienteGrupo>();
        }

        #endregion
    }
}