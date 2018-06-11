using OC2017.DAO;
using OC2017.Model;
using OC2017.Util.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OC2017.Messages
{
    class MessageLogin
    {
        string message1 = "Login vazio!";
        public bool E_USUARIO_INVALIDO(string login)
        {
            VERIFICA_IDIOMA();
            if (login.Length > 0)
            {
                return true;
            }
            MessageBox.Show(message1);
            return false;
        }

        string message2 = "Login e/ou senha incorretos!";
        public bool E_LOGIN_FALHOU(string login, string senha)
        {
            VERIFICA_IDIOMA();
            PessoaDAO dao = new PessoaDAO();
            foreach(Pessoa p in dao.Select())
            {
                if (p.Login.Equals(login) && p.Senha.Equals(senha))
                {
                    PessoaLogada.instance = p;
                    return true;
                }
            }
            MessageBox.Show(message2);
            return false;
        }

        private void VERIFICA_IDIOMA()
        {
            if (MessageManager.idiomaAtual.Equals("pt-BR"))
            {
                message1 = "Login vazio!";
                message2 = "Login e/ou senha incorretos!";
            }
            else
            {
                message1 = "Login empty!";
                message2 = "Login and/or password incorrects!";
            }
        }
    }
}
