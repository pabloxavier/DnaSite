using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DNAMais.Domain.Extensions;


namespace DNAMais.Domain
{
    [Table("NEWSLETTER", Schema = "DNASITE")]
    public class Newsletter
    {
        #region Public Properties

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_NEWSLETTER")]
        [Index("IDX_NEWSLETTER")]
        public int? Id { get; set; }

        [Required]
        [Column("CD_GUID")]
        [MaxLength(32)]
        public string GUID { get; set; }

        [Required]
        [Column("NM_SUBSCRIPTION")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [Column("DS_EMAIL_CONTACT")]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [Column("DT_REGISTER")]
        public DateTime? Register { get; set; }

        [NotMapped]
        public bool? OptIn { get; set; }

        [Column("IS_OPT_IN")]
        public string OptInText
        {
            get { return OptIn.ParseFlag(); }
            set { OptIn = value.ParseFlag(); }
        }

        [Column("DT_OPT_IN")]
        public DateTime? RegisterOptIn { get; set; }

        [NotMapped]
        public bool? OptOut { get; set; }

        [Column("IS_OPT_OUT")]
        public string OptOutText 
        {
            get { return OptOut.ParseFlag(); }
            set { OptOut = value.ParseFlag(); }
        }

        [Column("DT_OPT_OUT")]
        public DateTime? RegisterOptOut { get; set; }

        #endregion

        #region Constructor
        public Newsletter()
        {

        }
        #endregion
    }
}
