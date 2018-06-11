using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    public class EventoDAO
    {
        public void Add(Evento evento)
        {
            Contexto contexto = new Contexto();
            contexto.Eventos.Add(evento);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Evento> Select()
        {
            Contexto contexto = new Contexto();
            List<Evento> Eventos = contexto.Eventos.ToList();
            contexto.Dispose();
            return Eventos;
        }

        public Evento Last()
        {
            Contexto contexto = new Contexto();
            Evento LastEvento = new Evento();
            //LastEvento = contexto.Eventos.OrderByDescending(x => x).Take(1).Last();

            foreach (Evento e in Select())
            {
                LastEvento = e;
            }

            contexto.Dispose();
            return LastEvento;
        }
    }
}
