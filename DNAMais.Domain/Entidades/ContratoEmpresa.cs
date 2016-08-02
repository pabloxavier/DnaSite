using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("CONTRATO_EMPRESA", Schema = "DNASITE")]
    public class ContratoEmpresa
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_CONTRATO_EMPRESA")]
        public int? Id { get; set; }

        [Required]
        [Column("ID_CLIENTE_EMPRESA")]
        public int? IdClienteEmpresa { get; set; }
        [ForeignKey("IdClienteEmpresa")]
        public virtual ClienteEmpresa ClienteEmpresa { get; set; }

        [Required]
        [Column("NR_CONTRATO")]
        public int? Numero { get; set; }

        [Required]
        [Column("DT_AQUISICAO")]
        public DateTime? DataAquisicao { get; set; }

        [Required]
        [Column("IS_VIGENTE")]
        public bool? Vigente { get; set; }

        [Required]
        [Column("DD_CORTE")]
        public byte? DiaCorte { get; set; }

        [Required]
        [Column("DD_FATURAMENTO")]
        public byte? DiaFaturamento { get; set; }

        [Column("DT_PREVISAO_ENCERRAMENTO")]
        public DateTime? DataEncerramento { get; set; }

        [Required]
        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

        [Required]
        [Column("ID_USUARIO_CADASTRO")]
        public int? IdUsuarioCadastro { get; set; }
        [ForeignKey("IdUsuarioCadastro")]
        public virtual UsuarioBackoffice UsuarioBackoffice { get; set; }

        public virtual IEnumerable<ContratoEmpresaProduto> ContratosEmpresasProdutos { get; set; }
        public virtual IEnumerable<ContratoEmpresaPrecificacao> ContratosEmpresasPrecificacoes { get; set; }

        #endregion

        #region Construtor

        public ContratoEmpresa()
        {

        }

        #endregion
    }
}
