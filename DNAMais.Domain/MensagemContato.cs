using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain
{
    [Table("MENSAGEM_CONTATO", Schema = "DNASITE")]
    public class MensagemContato
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public DateTime? RegisterDate { get; set; }

        [Required]
        [Column("IS_RESPONDIDA")]
        public byte? Respondida { get; set; }

        [Column("ID_USUARIO_BACKOFFICE_RESPOSTA")]
        public int? IdUsuarioBackofficeResposta { get; set; }

        [ForeignKey("IdBackOfficeUserAnswer")]
        public virtual UsuarioBackoffice BackOfficeUserAnswer { get; set; }

        [Column("DT_ANSWER")]
        public DateTime? Answer { get; set; }

        #endregion

        #region Construtor

        public MensagemContato()
        {
            
        }

        #endregion
    }
}
