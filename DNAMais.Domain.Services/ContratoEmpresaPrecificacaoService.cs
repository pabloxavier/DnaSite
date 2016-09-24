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
    public class ContratoEmpresaPrecificacaoService
    {
        private DNAMaisSiteContext context;

        private Repository<ContratoEmpresaPrecificacao> repoContratoEmpresaPrecificacao;

        public ContratoEmpresaPrecificacaoService()
        {
            context = new DNAMaisSiteContext();
            repoContratoEmpresaPrecificacao = new Repository<ContratoEmpresaPrecificacao>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<ContratoEmpresaPrecificacao> ListarTodos()
        {
            return repoContratoEmpresaPrecificacao.GetAll();
        }

        public ContratoEmpresaPrecificacao ConsultarPorId(int id)
        {
            return repoContratoEmpresaPrecificacao.GetById(id);
        }

        public ResultValidation Salvar(ContratoEmpresaPrecificacao contratoEmpresaPrecificacao)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                repoContratoEmpresaPrecificacao.Update(contratoEmpresaPrecificacao);

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
            repoContratoEmpresaPrecificacao.Remove(id);
        }
    }
}
