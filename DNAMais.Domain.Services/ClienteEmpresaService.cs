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
    public class ClienteEmpresaService
    {
        private DNAMaisSiteContext context;

        private Repository<ClienteEmpresa> repoClienteEmpresa;

        public ClienteEmpresaService()
        {
            context = new DNAMaisSiteContext();
            repoClienteEmpresa = new Repository<ClienteEmpresa>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<ClienteEmpresa> ListarTodos()
        {
            return repoClienteEmpresa.GetAll();
        }

        public ClienteEmpresa ConsultarPorId(int id)
        {
            return repoClienteEmpresa.GetById(id);
        }

        public ResultValidation Salvar(ClienteEmpresa clienteEmpresa)
        {
            ResultValidation returnValidation = new ResultValidation();

            if (!returnValidation.Ok) return returnValidation;

            try
            {
                if (clienteEmpresa.Id == null)
                {
                    clienteEmpresa.Id = new Random().Next(1, 999999);

                    clienteEmpresa.DataCadastro = DateTime.Now;

                    repoClienteEmpresa.Add(clienteEmpresa);
                }
                else
                {
                    repoClienteEmpresa.Update(clienteEmpresa);
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
            repoClienteEmpresa.Remove(id);
        }
    }
}
