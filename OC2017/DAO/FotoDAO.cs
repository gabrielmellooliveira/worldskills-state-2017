using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    public class FotoDAO
    {
        public void Add(Foto Foto)
        {
            Contexto contexto = new Contexto();
            contexto.Fotos.Add(Foto);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Foto> Select()
        {
            Contexto contexto = new Contexto();
            List<Foto> Fotos = contexto.Fotos.ToList();
            contexto.Dispose();
            return Fotos;
        }

        public Foto Last()
        {
            Contexto contexto = new Contexto();
            Foto LastFoto = contexto.Fotos.OrderByDescending(x => x).Take(1).Last();
            contexto.Dispose();
            return LastFoto;
        }
    }
}
