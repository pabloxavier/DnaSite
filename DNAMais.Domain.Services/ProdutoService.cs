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
    public class ProdutoService
    {
        private DNAMaisSiteContext context;

        private Repository<Produto> repoProduto;

        public ProdutoService()
        {
            context = new DNAMaisSiteContext();
            repoProduto = new Repository<Produto>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<Produto> ListarTodos()
        {
            return repoProduto.GetAll();
        }

        public Produto ConsultarPorId(string id)
        {
            return repoProduto.GetById(id);
        }
    }
}
