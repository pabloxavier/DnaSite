using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DNAMais.Domain.Extensions;


namespace DNAMais.Domain.Entidades
{
    [Table("NEWSLETTER", Schema = "DNASITE")]
    public class Newsletter
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_NEWSLETTER")]
        [Index("TS_DNASITE_INDEX")]
        public int? Id { get; set; }

        [Required]
        [Column("CD_GUID")]
        [StringLength(32)]
        [Index("NEWSLETTER_IDX_02")]
        public string GUID { get; set; }

        [Required]
        [Column("NM_INSCRICAO")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [Column("DS_EMAIL")]
        [StringLength(80)]
        [Index("NEWSLETTER_IDX_01")]
        public string Email { get; set; }

        [Required]
        [Column("DT_REGISTRO")]
        public DateTime? DataRegistro { get; set; }

        [NotMapped]
        public bool? OptIn { get; set; }

        [Required]
        [Column("IS_OPT_IN")]
        public string OptInText
        {
            get { return OptIn.ParseFlag(); }
            set { OptIn = value.ParseFlag(); }
        }

        [Column("DT_OPT_IN")]
        public DateTime? DataRegistroOptIn { get; set; }

        [NotMapped]
        public bool? OptOut { get; set; }

        [Required]
        [Column("IS_OPT_OUT")]
        public string OptOutText 
        {
            get { return OptOut.ParseFlag(); }
            set { OptOut = value.ParseFlag(); }
        }

        [Column("DT_OPT_OUT")]
        public DateTime? DataRegistroOptOut { get; set; }

        #endregion

        #region Construtor

        public Newsletter()
        {

        }

        #endregion
    }
}
