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
    public class TipoContatoService
    {
        private DNAMaisSiteContext context;

        private Repository<TipoContato> repoTipoContato;

        public TipoContatoService()
        {
            context = new DNAMaisSiteContext();
            repoTipoContato = new Repository<TipoContato>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<TipoContato> ListarTodos()
        {
            return repoTipoContato.GetAll();
        }

        public TipoContato ConsultarPorId(int id)
        {
            return repoTipoContato.GetById(id);
        }

        public ResultValidation Salvar(TipoContato tipoContato)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                if (tipoContato.Id == null)
                {
                    tipoContato.Id = new Random().Next(1, 999999);

                    tipoContato.DataCadastro = DateTime.Now;

                    repoTipoContato.Add(tipoContato);
                }
                else
                {
                    repoTipoContato.Update(tipoContato);
                }

                context.SaveChanges();
            }
            catch (Exception err)
            {
                returnValidation.AddMessage("", err.Message);
            }

            return returnValidation;
        }

        public void Excluir(int id)
        {
            repoTipoContato.Remove(id);
        }
    }
}
