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

        private Repository<Message> repoMessage;

        public MessageService()
        {
            context = new DNAMaisSiteContext();
            repoMessage = new Repository<Message>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Message GetById(int id)
        {
            return repoMessage.GetById(id);
        }

        public Message Add(Message teste)
        {
            //var newEntry = repoMessage.Add(teste);
            //return newEntry;

            return repoMessage.Add(teste);
        }

        public void Update(Message teste)
        {
            var entry = context.Entry(teste);
            entry.State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(Message teste)
        {
            repoMessage.Remove(teste);
        }

        public IQueryable<Message> ListAnswered()
        {
            return repoMessage.Filter(i => i.Answered == 1);
        }

        public IQueryable<Message> ListNonAnswered()
        {
            return repoMessage.Filter(i => i.Answered == 0);
        }

        //public Message AssignAnswer()
        //{

        //}
    }
}
