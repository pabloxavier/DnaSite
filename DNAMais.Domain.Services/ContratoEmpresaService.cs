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
    public class ContratoEmpresaService
    {
        private DNAMaisSiteContext context;

        private Repository<ContratoEmpresa> repoContratoEmpresa;

        public ContratoEmpresaService()
        {
            context = new DNAMaisSiteContext();
            repoContratoEmpresa = new Repository<ContratoEmpresa>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<ContratoEmpresa> ListarTodos()
        {
            return repoContratoEmpresa.GetAll();
        }

        public ContratoEmpresa ConsultarPorId(int id)
        {
            return repoContratoEmpresa.GetById(id);
        }

        public ResultValidation Salvar(ContratoEmpresa contratoEmpresa)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                if (contratoEmpresa.Id == null)
                {
                    contratoEmpresa.Id = new Random().Next(1, 999999);

                    contratoEmpresa.DataCadastro = DateTime.Now;

                    repoContratoEmpresa.Add(contratoEmpresa);
                }
                else
                {
                    repoContratoEmpresa.Update(contratoEmpresa);
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
            repoContratoEmpresa.Remove(id);
        }
    }
}
