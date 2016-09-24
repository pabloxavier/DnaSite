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
    [Table("MENSAGEM_CONTATO", Schema = "DNASITE")]
    [SequenceOracle("SQ_MENSAGEM_CONTATO")]
    public class MensagemContato
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_MENSAGEM_CONTATO")]
        [Index("TS_DNASITE_INDEX")]
        public int? Id { get; set; }

        [Required]
        [Column("NM_CONTATO")]
        [Display(Name="Nome")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [Column("DS_EMAIL")]
        [Display(Name="E-Mail")]
        [StringLength(80)]
        public string Email { get; set; }

        [Required]
        [Column("DS_ASSUNTO")]
        [Display(Name="Assunto")]
        [StringLength(40)]
        public string Assunto { get; set; }

        [Required]
        [Column("DS_CONTEUDO")]
        [Display(Name="Conteúdo")]
        [StringLength(1000)]
        public string Conteudo { get; set; }

        [Required]
        [Column("DT_REGISTRO")]
        [Display(Name="Data de Registro")]
        public DateTime? DataRegistro { get; set; }

        [Required]
        [Column("IS_RESPONDIDA")]
        public bool? Respondida { get; set; }

        [Column("ID_USUARIO_BACKOFFICE_RESPOSTA")]
        [Index("MENSAGEM_CONTATO_IDX_01")]
        public int? IdUsuarioBackOfficeResposta { get; set; }
        [ForeignKey("IdUsuarioBackOfficeResposta")]
        public virtual UsuarioBackOffice UsuarioBackOffice { get; set; }

        [Column("DT_RESPOSTA")]
        public DateTime? DataResposta { get; set; }

        [Column("DS_RESPOSTA")]
        [StringLength(1000)]
        public string DescricaoResposta { get; set; }

        #endregion

        #region Construtor

        public MensagemContato()
        {
            
        }

        #endregion
    }
}
