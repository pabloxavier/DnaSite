using DNAMais.Domain.Entidades;
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
    public class UfService
    {
        private DNAMaisSiteContext context;

        private Repository<Uf> repoUf;

        public UfService()
        {
            context = new DNAMaisSiteContext();
            repoUf = new Repository<Uf>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<Uf> ListarTodos()
        {
            return repoUf.GetAll();
        }

        public Uf ConsultarPorSigla(string sigla)
        {
            return repoUf.GetById(sigla);
        }
    }
}
