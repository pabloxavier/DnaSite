using DNAMais.Framework;
using DNAMais.Infrastructure.Data.Contexts;
using DNAMais.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Services
{
    public class BackOfficeUserService
    {
        private DNAMaisSiteContext context;

        private Repository<UsuarioBackoffice> repoBackOfficeUser;

        public BackOfficeUserService()
        {
            context = new DNAMaisSiteContext();
            repoBackOfficeUser = new Repository<UsuarioBackoffice>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<UsuarioBackoffice> GetAll()
        {
            return repoBackOfficeUser.GetAll();
        }

        public UsuarioBackoffice GetById(int id)
        {
            return repoBackOfficeUser.GetById(id);
        }

        public UsuarioBackoffice GetByLogin(string login)
        {
            return repoBackOfficeUser.FindFirst(i => i.Login == login);
        }

        public UsuarioBackoffice Add(UsuarioBackoffice teste)
        {
            //var newEntry = repoBackOfficeUser.Add(teste);
            //return newEntry;

            return repoBackOfficeUser.Add(teste);
        }

        public void Update(UsuarioBackoffice teste)
        {
            var entry = context.Entry(teste);
            entry.State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(UsuarioBackoffice teste)
        {
            repoBackOfficeUser.Remove(teste);
        }
    }
}
