using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades
{
    [Table("TRANSACAO_CONSULTA", Schema = "DNASITE")]
    public class TransacaoConsulta
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_TRANSACAO_CONSULTA")]
        public int? Id { get; set; }

        [Required]
        [Column("ID_CLIENTE_EMPRESA")]
        public int? IdClienteEmpresa { get; set; }
        [ForeignKey("IdClienteEmpresa")]
        public virtual ClienteEmpresa ClienteEmpresa { get; set; }

        [Required]
        [Column("ID_CONTRATO_EMPRESA")]
        public int? IdContratoEmpresa { get; set; }
        [ForeignKey("IdContratoEmpresa")]
        public virtual ContratoEmpresa ContratoEmpresa { get; set; }

        [Required]
        [Column("ID_USUARIO_CLIENTE")]
        public int? IdUsuarioCliente { get; set; }
        [ForeignKey("IdUsuarioCliente")]
        public virtual UsuarioCliente UsuarioCliente { get; set; }

        [Required]
        [Column("CD_ITEM_PRODUTO")]
        public string CodigoItemProduto { get; set; }
        [ForeignKey("CodigoItemProduto")]
        public virtual ItemProduto ItemProduto { get; set; }

        [Required]
        [Column("IS_DADOS_ENCONTRADOS")]
        public bool? DadosEncontrados { get; set; }

        [Required]
        [Column("NR_PROTOCOLO_CONSULTA")]
        public int? ProtocoloConsulta { get; set; }

        [Required]
        [Column("DT_TRANSACAO")]
        public DateTime? DataTransacao { get; set; }

        [Required]
        [Column("IS_FATURADA")]
        public bool? Faturada { get; set; }

        [Column("ID_FATURAMENTO")]
        public int? IdFaturamento { get; set; }
        [ForeignKey("IdFaturamento")]
        public virtual Faturamento Faturamento { get; set; }

        #endregion

        #region Construtor

        public TransacaoConsulta()
        {

        }

        #endregion
    }
}
