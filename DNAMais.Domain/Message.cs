using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain
{
    [Table("MESSAGE", Schema = "DNASITE")]
    public class Message
    {
        #region Public Properties

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_MESSAGE")]
        [Index("IDX_MESSAGE")]
        public int? Id { get; set; }

        [Required]
        [Column("NM_USER")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [Column("DS_EMAIL_USER")]
        [MaxLength(80)]
        public string Email { get; set; }

        [Column("DS_SUBJECT_MESSAGE")]
        [MaxLength(40)]
        public string Subject { get; set; }

        [Required]
        [Column("DS_CONTENT_MESSAGE")]
        [MaxLength(300)]
        public string Content { get; set; }

        [Required]
        [Column("DT_REGISTER_MESSAGE")]
        public DateTime? RegisterDate { get; set; }

        [Required]
        [Column("IS_ANSWERED")]
        public byte? Answered { get; set; }

        [Column("ID_USER_ANSWER")]
        public int? IdBackOfficeUserAnswer { get; set; }

        [ForeignKey("IdBackOfficeUserAnswer")]
        public virtual BackOfficeUser BackOfficeUserAnswer { get; set; }

        [Column("DT_ANSWER")]
        public DateTime? Answer { get; set; }

        #endregion

        #region Constructor
        public Message()
        {
            
        }
        #endregion
    }
}
