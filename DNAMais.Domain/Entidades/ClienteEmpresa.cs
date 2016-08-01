using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("CLIENTE_EMPRESA", Schema = "DNASITE")]
    public class ClienteEmpresa
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_CLIENTE_EMPRESA")]
        public int? Id { get; set; }

        [Required]
        [Index("TS_DNASITE_INDEX", 1, IsUnique = true)]
        [Column("NR_CNPJ")]
        public long? Cnpj { get; set; }

        [Required]
        [Column("NM_RAZAO_SOCIAL")]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Required]
        [Column("NM_FANTASIA")]
        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [Required]
        [Column("ID_RAMO_ATIVIDADE")]
        public int? IdRamoAtividade { get; set; }
        [ForeignKey("IdRamoAtividade")]
        public virtual RamoAtividade RamoAtividade { get; set; }

        [Required]
        [Column("CD_STATUS_CLIENTE_EMPRESA")]
        public short? CodigoStatus { get; set; }
        [ForeignKey("CodigoStatus")]
        public virtual StatusClienteEmpresa StatusClienteEmpresa { get; set; }

        [Required]
        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_CADASTRO")]
        public int? IdUsuarioCadastro { get; set; }
        [ForeignKey("IdUsuarioCadastro")]
        public virtual UsuarioBackoffice UsuarioBackoffice { get; set; }

        public virtual IEnumerable<ClienteEmpresaEndereco> ClientesEmpresasEnderecos { get; set; }
        public virtual IEnumerable<ClienteEmpresaContato> ClientesEmpresasContatos { get; set; }

        #endregion

        #region Construtor

        public ClienteEmpresa()
        {

        }

        #endregion
    }
}
