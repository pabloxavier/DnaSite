using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain
{
    [Table("BO_USER", Schema = "DNASITE")]
    public class BackOfficeUser
    {
        #region Public Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("ID_USER")]
        [Index("IDX_PK_BO_USER")]
        public int? Id { get; set; }

        [Index("IDX_UNQ_BO_USER", 1, IsUnique = true)]
        [Required]
        [Column("NM_USER")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Index("IDX_UNQ_BO_USER", 2, IsUnique = true)]
        [Required]
        [Column("DS_EMAIL_USER")]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [Column("DS_LOGIN")]
        [MaxLength(20)]
        public string Login { get; set; }

        [Required]
        [Column("DS_PASSWORD")]
        [MaxLength(32)]
        public string Password { get; set; }

        [Required]
        [Column("DT_CREATION")]
        public DateTime? CreationDate { get; set; }

        [Required]
        [Column("IS_ADMIN")]
        public byte? Admin { get; set; }

        public virtual ICollection<Message> AnsweredMessages { get; set; }

        #endregion

        #region Constructor
        public BackOfficeUser()
        {
            AnsweredMessages = new HashSet<Message>();
        }
        #endregion
    }
}