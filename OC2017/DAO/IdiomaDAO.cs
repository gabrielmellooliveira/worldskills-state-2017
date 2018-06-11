using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    class IdiomaDAO
    {
        public void Add(Idioma idioma)
        {
            Contexto contexto = new Contexto();
            contexto.Idiomas.Add(idioma);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Idioma> Select()
        {
            Contexto contexto = new Contexto();
            List<Idioma> Idiomas = contexto.Idiomas.ToList();
            contexto.Dispose();
            return Idiomas;
        }

        public void Edit(Idioma idioma)
        {
            Contexto contexto = new Contexto();
            Idioma idi = contexto.Idiomas.FirstOrDefault(u => u.Id == idioma.Id);
            idi = idioma;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Delete(Idioma idioma)
        {
            Contexto contexto = new Contexto();
            contexto.Idiomas.Remove(idioma);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Idioma ById(int id)
        {
            Contexto contexto = new Contexto();
            Idioma idi = contexto.Idiomas.FirstOrDefault(u => u.Id == id);
            contexto.Dispose();
            return idi;
        }
    }
}
