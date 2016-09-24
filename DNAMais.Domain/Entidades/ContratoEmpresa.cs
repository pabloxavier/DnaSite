﻿using DNAMais.Domain.CustomAttributes;
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_CONTRATO_EMPRESA")]
        public int? Id { get; set; }

        [Required]
        [Column("ID_CLIENTE_EMPRESA")]
        [Display(Name = "Cliente")]
        public int? IdClienteEmpresa { get; set; }
        [ForeignKey("IdClienteEmpresa")]
        public virtual ClienteEmpresa ClienteEmpresa { get; set; }

        [Required]
        [Column("NR_CONTRATO")]
        [Display(Name = "Número Contrato")]
        public int? Numero { get; set; }

        [Required]
        [Column("DT_AQUISICAO")]
        [Display(Name = "Data de Aquisição")]
        public DateTime? DataAquisicao { get; set; }

        [NotMapped]
        public bool? Vigente { get; set; }

        [Column("IS_VIGENTE")]
        public string VigenteDescricao
        {
            get { return Vigente ?? false ? "S" : "N"; }
            set { Vigente = value == "S" ? true : false; }
        }

        [Required]
        [Column("DD_CORTE")]
        [Display(Name = "Dia de Corte")]
        public byte? DiaCorte { get; set; }

        [Required]
        [Column("DD_FATURAMENTO")]
        [Display(Name = "Dia do Faturamento")]
        public byte? DiaFaturamento { get; set; }

        [Column("DT_CADASTRO")]
        public DateTime? DataCadastro { get; set; }

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
