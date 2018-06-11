using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.DAO
{
    public class EnderecoDAO
    {
        public void Add(Endereco endereco)
        {
            Contexto contexto = new Contexto();
            contexto.Enderecos.Add(endereco);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public List<Endereco> Select()
        {
            Contexto contexto = new Contexto();
            List<Endereco> Enderecos = contexto.Enderecos.ToList();
            contexto.Dispose();
            return Enderecos;
        }

        public Endereco Last()
        {
            Contexto contexto = new Contexto();
            Endereco LastEndereco = new Endereco();
            //LastEndereco = contexto.Enderecos.OrderBy(x => x.Id).Take(1).Last();

            foreach(Endereco e in Select())
            {
                LastEndereco = e;
            }

            contexto.Dispose();
            return LastEndereco;
        }
    }
}
