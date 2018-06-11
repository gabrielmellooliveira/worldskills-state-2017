using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    class PerfilDAO
    {
        public void Add(Perfil perfil)
        {
            Contexto contexto = new Contexto();
            contexto.Perfis.Add(perfil);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Perfil> Select()
        {
            Contexto contexto = new Contexto();
            List<Perfil> Perfis = contexto.Perfis.ToList();
            contexto.Dispose();
            return Perfis;
        }

        public void Edit(Perfil perfil)
        {
            Contexto contexto = new Contexto();
            Perfil p = contexto.Perfis.FirstOrDefault(u => u.Id == perfil.Id);
            p = perfil;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Delete(Perfil perfil)
        {
            Contexto contexto = new Contexto();
            contexto.Perfis.Remove(perfil);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Perfil ById(int id)
        {
            Contexto contexto = new Contexto();
            Perfil p = contexto.Perfis.FirstOrDefault(u => u.Id == id);
            contexto.Dispose();
            return p;
        }
    }
}
