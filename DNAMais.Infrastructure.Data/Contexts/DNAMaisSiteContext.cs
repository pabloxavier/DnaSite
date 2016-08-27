﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using DNAMais.Domain;
using DNAMais.Domain.Entidades;
using System.IO;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.ComponentModel;
using DNAMais.Domain.CustomAttributes;
using System.Data.Entity.Core.Metadata.Edm;
using System.Reflection;

namespace DNAMais.Infrastructure.Data.Contexts
{
    public class DNAMaisSiteContext : DbContext
    {
        private readonly StreamWriter arquivoLog;

        public DNAMaisSiteContext() :
            base("connDnaMais")
        {
            if (arquivoLog == null)
            {
                //arquivoLog = new StreamWriter("C:\\temp\\logDna.txt");

            }

            //Database.Log = arquivoLog.WriteLine;

            Database.SetInitializer<DNAMaisSiteContext>(null);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && arquivoLog != null)
            {
                arquivoLog.Dispose();
            }

            base.Dispose(disposing);
        }


        private IEnumerable<string> GetPropertyKeys<T>(T t)
            where T : class
        {
            ObjectContext objectContext = ((IObjectContextAdapter)this).ObjectContext;

            ObjectSet<T> set = objectContext.CreateObjectSet<T>();

            IEnumerable<string> keyNames = set.EntitySet.ElementType
                                            .KeyMembers
                                            .Select(k => k.Name);

            return keyNames;
        }

        public string GetSequenceValue(string sequenceName)
        {
            string command = string.Format("SELECT {0}.NEXTVAL FROM DUAL", sequenceName);

            var oracleCommand = Database.Connection.CreateCommand();

            oracleCommand.CommandText = command;

            if (Database.Connection.State == System.Data.ConnectionState.Closed)
            {
                Database.Connection.Open();
            }

            return oracleCommand.ExecuteScalar().ToString();
        }

        public override int SaveChanges()
        {
            foreach (var changeSet in ChangeTracker.Entries())
            {
                var entity = changeSet.Entity;

                var entityType = entity.GetType();

                if (entityType == null)
                {
                    break;
                }

                var entityCustomAttributes = TypeDescriptor.GetAttributes(entityType);

                if (entityCustomAttributes == null)
                {
                    break;
                }

                if (entityCustomAttributes.Count == 0)
                {
                    break;
                }

                foreach (Attribute attribute in entityCustomAttributes)
                {
                    if (attribute is SequenceOracle)
                    {
                        string sequenceName = ((SequenceOracle)attribute).SequenceName;

                        if (!string.IsNullOrWhiteSpace(sequenceName))
                        {
                            string sequenceValue = GetSequenceValue(sequenceName);

                            // Obter a instância do Contexto
                            ObjectContext objectContext = ((IObjectContextAdapter)this).ObjectContext;

                            // Obter a Entrada da Entidade
                            EntitySetBase entitySet = objectContext
                                                        .ObjectStateManager
                                                        .GetObjectStateEntry(entity)
                                                        .EntitySet;

                            // Obter as Propriedades (Nomes) que compõem o Identificador da Entidade
                            List<string> propertyKeyNames = entitySet
                                                                .ElementType
                                                                .KeyMembers
                                                                .Select(k => k.Name).ToList();

                            // Para entidades definidas com Sequence, não é possível qualquer possibilidade
                            // que a entidade tenha 0 (zero) ou +1 (mais de um) identificador
                            if (propertyKeyNames.Count != 1)
                            {
                                throw new Exception("Mapeamento de chaves incorreto.");
                            }

                            string propertyKeyName = propertyKeyNames[0];

                            // Obter a Propriedade / Identificador da Entidade
                            PropertyInfo propertyKey = entityType.GetProperty(propertyKeyName);

                            // Obter o Tipo da Propridade / Identificador da Entidade
                            // Necessário para tornar possível converter o valor obtido da Sequence
                            // no Tipo correto da Propriedade
                            Type propertyKeyType = Nullable.GetUnderlyingType(propertyKey.PropertyType) ?? propertyKey.PropertyType;

                            // Assegurar o Tipo correto da Propridade de Identificação
                            // Conversão do valor da Sequence de string para Tipo correto
                            object sequenceValueCorrectType = Convert.ChangeType(sequenceValue, propertyKeyType);

                            propertyKey.SetValue(entity, sequenceValueCorrectType);
                        }

                        break;
                    }
                }
            }

            return base.SaveChanges();
        }

        public DbSet<UsuarioBackOffice> BackOfficeUsers { get; set; }
        public DbSet<MensagemContato> Messages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<TipoContato> TiposContato { get; set; }
        public DbSet<TipoEndereco> TiposEndereco { get; set; }
        public DbSet<RamoAtividade> RamosAtividade { get; set; }
        public DbSet<PerfilAcessoBackOffice> PerfisAcessoBackOffice { get; set; }
        public DbSet<PerfilAcessoFuncionalidade> PerfisAcessoFuncionalidades { get; set; }
        public DbSet<FuncionalidadeBackOffice> FuncionalidadesBackOffice { get; set; }

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
