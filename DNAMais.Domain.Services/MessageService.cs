using DNAMais.Infrastructure.Data.Contexts;
using DNAMais.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAMais.Domain.Services
{
    public class MessageService
    {
        private DNAMaisSiteContext context;

        private Repository<MensagemContato> repoMessage;

        public MessageService()
        {
            context = new DNAMaisSiteContext();
            repoMessage = new Repository<MensagemContato>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public MensagemContato GetById(int id)
        {
            return repoMessage.GetById(id);
        }

        public MensagemContato Add(MensagemContato teste)
        {
            //var newEntry = repoMessage.Add(teste);
            //return newEntry;

            return repoMessage.Add(teste);
        }

        public void Update(MensagemContato teste)
        {
            var entry = context.Entry(teste);
            entry.State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(MensagemContato teste)
        {
            repoMessage.Remove(teste);
        }

        public IQueryable<MensagemContato> ListAnswered()
        {
            return repoMessage.Filter(i => i.Respondida == 1);
        }

        public IQueryable<MensagemContato> ListNonAnswered()
        {
            return repoMessage.Filter(i => i.Respondida == 0);
        }

        //public Message AssignAnswer()
        //{

        //}
    }
}
