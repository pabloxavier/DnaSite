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
    public class ItemProdutoService
    {
        private DNAMaisSiteContext context;

        private Repository<ItemProduto> repoItemProduto;

        public ItemProdutoService()
        {
            context = new DNAMaisSiteContext();
            repoItemProduto = new Repository<ItemProduto>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<ItemProduto> ListarTodos()
        {
            return repoItemProduto.GetAll();
        }

        public ItemProduto ConsultarPorId(string id)
        {
            return repoItemProduto.GetById(id);
        }
    }
}
