using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    class FuncionalidadeDAO
    {
        public void Add(Funcionalidade funcionalidade)
        {
            Contexto contexto = new Contexto();
            contexto.Funcionalidades.Add(funcionalidade);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Funcionalidade> Select()
        {
            Contexto contexto = new Contexto();
            List<Funcionalidade> Funcionalidades = contexto.Funcionalidades.ToList();
            contexto.Dispose();
            return Funcionalidades;
        }

        public void Edit(Funcionalidade funcionalidade)
        {
            Contexto contexto = new Contexto();
            Funcionalidade f = contexto.Funcionalidades.FirstOrDefault(u => u.Id == funcionalidade.Id);
            f = funcionalidade;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Delete(Funcionalidade funcionalidade)
        {
            Contexto contexto = new Contexto();
            contexto.Funcionalidades.Remove(funcionalidade);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
