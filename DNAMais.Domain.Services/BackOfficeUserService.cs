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

        private Repository<BackOfficeUser> repoBackOfficeUser;

        public BackOfficeUserService()
        {
            context = new DNAMaisSiteContext();
            repoBackOfficeUser = new Repository<BackOfficeUser>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<BackOfficeUser> GetAll()
        {
            return repoBackOfficeUser.GetAll();
        }

        public BackOfficeUser GetById(int id)
        {
            return repoBackOfficeUser.GetById(id);
        }

        public BackOfficeUser GetByLogin(string login)
        {
            return repoBackOfficeUser.FindFirst(i => i.Login == login);
        }

        public BackOfficeUser Add(BackOfficeUser teste)
        {
            //var newEntry = repoBackOfficeUser.Add(teste);
            //return newEntry;

            return repoBackOfficeUser.Add(teste);
        }

        public void Update(BackOfficeUser teste)
        {
            var entry = context.Entry(teste);
            entry.State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(BackOfficeUser teste)
        {
            repoBackOfficeUser.Remove(teste);
        }
    }
}
