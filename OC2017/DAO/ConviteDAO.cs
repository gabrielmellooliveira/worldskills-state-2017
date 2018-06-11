using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    public class ConviteDAO
    {
        public void Add(Convite Convite)
        {
            Contexto contexto = new Contexto();
            contexto.Convites.Add(Convite);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Convite> Select()
        {
            Contexto contexto = new Contexto();
            List<Convite> Convites = contexto.Convites.ToList();
            contexto.Dispose();
            return Convites;
        }

        public Convite Last()
        {
            Contexto contexto = new Contexto();
            Convite LastConvite = contexto.Convites.OrderByDescending(x => x).Take(1).Last();
            contexto.Dispose();
            return LastConvite;
        }
    }
}
