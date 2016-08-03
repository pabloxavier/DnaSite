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

        private Repository<UsuarioBackOffice> repoBackOfficeUser;

        public BackOfficeUserService()
        {
            context = new DNAMaisSiteContext();
            repoBackOfficeUser = new Repository<UsuarioBackOffice>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<UsuarioBackOffice> GetAll()
        {
            return repoBackOfficeUser.GetAll();
        }

        public UsuarioBackOffice GetById(int id)
        {
            return repoBackOfficeUser.GetById(id);
        }

        public UsuarioBackOffice GetByLogin(string login)
        {
            return repoBackOfficeUser.FindFirst(i => i.Login == login);
        }

        public UsuarioBackOffice Add(UsuarioBackOffice teste)
        {
            //var newEntry = repoBackOfficeUser.Add(teste);
            //return newEntry;

            return repoBackOfficeUser.Add(teste);
        }

        public void Update(UsuarioBackOffice teste)
        {
            var entry = context.Entry(teste);
            entry.State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(UsuarioBackOffice teste)
        {
            repoBackOfficeUser.Remove(teste);
        }
    }
}
