using OC2017.DAO;
using OC2017.Messages;
using OC2017.Model;
using OC2017.Util;
using OC2017.Util.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OC2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageLogin message = new MessageLogin();
            if (message.E_USUARIO_INVALIDO(tbLogin.Text) &&
                message.E_LOGIN_FALHOU(tbLogin.Text, tbSenha.Text))
            {
                Language.AjustaCultura(this, PessoaLogada.instance.Idioma.Sigla);
                MessageManager.idiomaAtual = PessoaLogada.instance.Idioma.Sigla;

                Form form = new FormMenu();
                form.Show();

                //this.Close();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form form = new FormRegisterPerson();
            form.Show();

            //this.Close();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pt-BR
            //en-US

            string currentLanguage = cbLanguage.SelectedItem.ToString();

            Language.AjustaCultura(this, currentLanguage);

            MessageManager.idiomaAtual = currentLanguage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDataBase.create();
            
            /*PessoaDAO dao = new PessoaDAO();
            foreach(Pessoa p in dao.Select())
            {
                dao.Delete(p);
            }*/

            /*PerfilDAO dao = new PerfilDAO();
            if (dao.Select().Count <= 0) {
                dao.Add(new Model.Perfil() {
                    Nome = "Administrador"
                });
                dao.Add(new Model.Perfil()
                {
                    Nome = "Cliente"
                });
            }

            IdiomaDAO dao3 = new IdiomaDAO();
            if (dao3.Select().Count <= 0)
            {
                dao3.Add(new Model.Idioma()
                {
                    Nome = "Português",
                    Sigla = "pt-BR",
                    Foto = "portugues"
                });
                dao3.Add(new Model.Idioma()
                {
                    Nome = "Inglês",
                    Sigla = "en-US",
                    Foto = "ingles"
                });
            }*/

            IdiomaDAO dao2 = new IdiomaDAO();
            cbLanguage.Items.Clear();
            cbLanguage.Items.AddRange(dao2.Select().ToArray());
        }

        private void lbInvite_Click(object sender, EventArgs e)
        {
            Form form = new FormOC();
            form.Show();
        }
    }
}
