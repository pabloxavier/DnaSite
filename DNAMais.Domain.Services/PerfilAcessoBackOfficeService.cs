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
    public class PerfilAcessoBackOfficeService
    {
        private DNAMaisSiteContext context;

        private Repository<PerfilAcessoBackOffice> repoPerfilAcessoBackOffice;

        public PerfilAcessoBackOfficeService()
        {
            context = new DNAMaisSiteContext();
            repoPerfilAcessoBackOffice = new Repository<PerfilAcessoBackOffice>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<PerfilAcessoBackOffice> ListarTodos()
        {
            return repoPerfilAcessoBackOffice.GetAll();
        }

        public PerfilAcessoBackOffice ConsultarPorId(byte id)
        {
            return repoPerfilAcessoBackOffice.GetById(id);
        }

        public ResultValidation Salvar(PerfilAcessoBackOffice perfilAcessoBackOffice)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                if (perfilAcessoBackOffice.Id == null)
                {
                    repoPerfilAcessoBackOffice.Add(perfilAcessoBackOffice);
                }
                else
                {
                    repoPerfilAcessoBackOffice.Update(perfilAcessoBackOffice);
                }

                context.SaveChanges();
            }
            catch (Exception err)
            {
                returnValidation.AddMessage("", err.Message);
            }

            return returnValidation;
        }

        public ResultValidation Excluir(byte id)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                repoPerfilAcessoBackOffice.Remove(id);

                context.SaveChanges();
            }
            catch (Exception err)
            {
                returnValidation.AddMessage("", err.Message);
            }

            return returnValidation;
        }
    }
}
