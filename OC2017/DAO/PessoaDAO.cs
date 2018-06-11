using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    class PessoaDAO
    {
        public void Add(Pessoa pessoa)
        {
            Contexto contexto = new Contexto();
            contexto.Pessoas.Add(pessoa);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Pessoa> Select()
        {
            Contexto contexto = new Contexto();
            List<Pessoa> Pessoas = new List<Pessoa>();

            PerfilDAO dao = new PerfilDAO();
            IdiomaDAO dao2 = new IdiomaDAO();

            foreach (Pessoa p in contexto.Pessoas.ToList())
            {
                if (p.Ativa == true)
                {
                    p.Perfil = dao.ById(p.IdPerfil);
                    p.Idioma = dao2.ById(p.IdIdioma);
                    Pessoas.Add(p);
                }
            }

            contexto.Dispose();
            return Pessoas;
        }

        public void Edit(Pessoa pessoa)
        {
            Contexto contexto = new Contexto();
            Pessoa p = contexto.Pessoas.FirstOrDefault(u => u.Id == pessoa.Id);
            p = pessoa;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Desabilita(Pessoa pessoa)
        {
            Contexto contexto = new Contexto();
            contexto.Pessoas.FirstOrDefault(u => u.Id == pessoa.Id).Ativa = false;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Delete(Pessoa pessoa)
        {
            Contexto contexto = new Contexto();
            contexto.Pessoas.Remove(pessoa);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
