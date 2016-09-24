using DNAMais.BackOffice.Facades.Base;
using DNAMais.Domain.Entidades;
using DNAMais.Domain.Services;
using DNAMais.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNAMais.BackOffice.Facades
{
    public class MensagemContatoFacade : BaseFacade, IDisposable
    {
        private MensagemContatoService serviceMensagem;

        public MensagemContatoFacade(ModelStateDictionary modelState)
            : base(modelState)
        {
            serviceMensagem = new MensagemContatoService();
        }

        public void Dispose()
        {
            serviceMensagem.Dispose();
        }

        #region Mensagem Contato

        public IQueryable<MensagemContato> ListarNaoRespondidas()
        {
            return serviceMensagem.ListarNaoRespondidas();
        }

        public IQueryable<MensagemContato> ListarRespondidas()
        {
            return serviceMensagem.ListarRespondidas();
        }

        public MensagemContato ConsultarMensagemPorId(int id)
        {
            var teste = serviceMensagem.ConsultarPorId(id);

            return serviceMensagem.ConsultarPorId(id);
        }

        public void SalvarMensagemContato(MensagemContato mensagemContato)
        {
            if (!modelState.IsValid)
            {
                return;
            }

            mensagemContato.DataResposta = DateTime.Now;
            mensagemContato.MensagemRespondida = "S";
            mensagemContato.IdUsuarioBackOfficeResposta = ((UsuarioBackOffice)HttpContext.Current.Session["user"]).Id;

            ResultValidation retorno = serviceMensagem.Salvar(mensagemContato);

            PreencherModelState(retorno);
        }

        #endregion

    }
}