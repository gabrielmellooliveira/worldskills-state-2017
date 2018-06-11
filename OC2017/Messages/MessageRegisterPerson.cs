using OC2017.DAO;
using OC2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OC2017.Messages
{
    class MessageRegisterPerson
    {
        public bool E_VERIFICA_EMAIL(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false;
        }
        
        public bool E_VERIFICA_NOME(string nome)
        {
            if (nome.Length > 0 && nome.Length < 11)
            {
                /*PessoaDAO dao = new PessoaDAO();
                foreach (Pessoa p in dao.Select())
                {
                    if (p.Nome.Equals(nome))
                    {
                        return true;
                    }
                }*/
                return true;
            }
            
            return false;
        }

        public bool E_VERIFICA_SENHA(string senha)
        {
            if (senha.Length > 0 && senha.Length < 11)
            {
                return true;
            }
            return false;
        }
    }
}
