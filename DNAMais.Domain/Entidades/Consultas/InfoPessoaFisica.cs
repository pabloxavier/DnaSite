using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Entidades.Consultas
{
    [Table("PESSOA_FISICA", Schema = "DNAINFO")]
    public class InfoPessoaFisica
    {
        #region Propriedades Públicas

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PESSOA_FISICA")]
        public long? Id { get; set; }

        [Required]
        [Column("NR_CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Column("NM_COMPLETO")]
        [StringLength(100)]
        public string NomeCompleto { get; set; }

        public virtual ICollection<InfoPessoaFisicaCadastro> InfosPessoasFisicasCadastros { get; set; }
        public virtual ICollection<InfoPessoaFisicaEmail> InfosPessoasFisicasEmails { get; set; }
        public virtual ICollection<InfoPessoaFisicaEndereco> InfosPessoasFisicasEnderecos { get; set; }
        public virtual ICollection<InfoPessoaFisicaTelefone> InfosPessoasFisicasTelefones { get; set; }

        #endregion

        #region Construtor

        public InfoPessoaFisica()
        {
            InfosPessoasFisicasCadastros = new HashSet<InfoPessoaFisicaCadastro>();
            InfosPessoasFisicasEmails = new HashSet<InfoPessoaFisicaEmail>();
            InfosPessoasFisicasEnderecos = new HashSet<InfoPessoaFisicaEndereco>();
            InfosPessoasFisicasTelefones = new HashSet<InfoPessoaFisicaTelefone>();
        }

        #endregion
    }
}
