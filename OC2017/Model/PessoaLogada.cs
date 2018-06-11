using OC2017.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class PessoaLogada
    {
        public static Pessoa instance;

        private PessoaLogada() { }

        public static Pessoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Pessoa();
                    foreach(Perfil p in new PerfilDAO().Select())
                    {
                        if (p.Nome.Equals("Cliente"))
                        {
                            instance.Perfil = p;
                        }
                    }
                }
                return instance;
            }
        }
    }
}
