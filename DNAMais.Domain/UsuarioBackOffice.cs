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
    public class UsuarioBackoffice
    {
        #region Propriedades Públicas

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("ID_USUARIO_BACKOFFICE")]
        [Index("TS_DNASITE_INDEX")]
        public int? Id { get; set; }

        [Index("TS_DNASITE_INDEX", 1, IsUnique = true)]
        [Required]
        [Column("NM_USUARIO")]
        public string Nome { get; set; }

        [Index("TS_DNASITE_INDEX", 2, IsUnique = true)]
        [Required]
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
        public byte? IdPerfilAcessoBackoffice { get; set; }

        public virtual ICollection<MensagemContato> AnsweredMessages { get; set; }

        #endregion

        #region Construtor

        public UsuarioBackoffice()
        {
            AnsweredMessages = new HashSet<MensagemContato>();
        }

        #endregion
    }
}