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
    [Table("CONTRATO_EMPRESA", Schema = "DNASITE")]
    [SequenceOracle("SQ_CONTRATO_EMPRESA")]
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
        public virtual UsuarioBackOffice UsuarioBackOffice { get; set; }

        public virtual ICollection<ContratoEmpresaProduto> ContratosEmpresasProdutos { get; set; }
        public virtual ICollection<ContratoEmpresaPrecificacao> ContratosEmpresasPrecificacoes { get; set; }
        public virtual ICollection<Faturamento> Faturamentos { get; set; }
        public virtual ICollection<TransacaoConsulta> TransacoesConsultas { get; set; }
        public virtual ICollection<SolicitacaoContagem> SolicitacoesContagens { get; set; }

        #endregion

        #region Construtor

        public ContratoEmpresa()
        {
            ContratosEmpresasProdutos = new HashSet<ContratoEmpresaProduto>();
            ContratosEmpresasPrecificacoes = new HashSet<ContratoEmpresaPrecificacao>();
            Faturamentos = new HashSet<Faturamento>();
            TransacoesConsultas = new HashSet<TransacaoConsulta>();
            SolicitacoesContagens = new HashSet<SolicitacaoContagem>();
        }

        #endregion
    }
}
