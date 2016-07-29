using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using DNAMais.Domain;

namespace DNAMais.Infrastructure.Data.Contexts
{
    public class DNAMaisSiteContext : DbContext
    {
        public DNAMaisSiteContext() :
            base("connDnaMais")
        {

        }

        public DbSet<UsuarioBackoffice> BackOfficeUsers { get; set; }
        public DbSet<MensagemContato> Messages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BackOfficeUser>()
            //    .HasMany<Message>(x => x.Email)
            //    .WithMany(x => x.BackOfficeUsers)
            //    .Map(x =>
            //    {
            //        x.ToTable("BackOfficeUser");
            //        x.MapLeftKey("Email");
            //        x.MapLeftKey("Name");
            //    });

            //base.OnModelCreating(modelBuilder);
        }

    }
}
