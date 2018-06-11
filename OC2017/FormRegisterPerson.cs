using OC2017.DAO;
using OC2017.Messages;
using OC2017.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OC2017
{
    public partial class FormRegisterPerson : Form
    {
        bool login;
        bool email;
        bool senha;

        Pessoa pessoaAtual = null;

        bool isAlter;

        public FormRegisterPerson(Pessoa pessoa)
        {
            InitializeComponent();

            tbName.Text = pessoa.Nome;
            tbEmail.Text = pessoa.Email;
            tbPhone.Text = pessoa.Telefone;
            tbLogin.Text = pessoa.Login;
            tbPassword.Text = pessoa.Senha;

            isAlter = true;

            pessoaAtual = pessoa;
        }

        public FormRegisterPerson()
        {
            InitializeComponent();
            isAlter = false;
        }

        private void FormRegisterPerson_Load(object sender, EventArgs e)
        {
            IdiomaDAO dao2 = new IdiomaDAO();
            cbLanguage.Items.Clear();
            cbLanguage.Items.AddRange(dao2.Select().ToArray());

            PerfilDAO dao3 = new PerfilDAO();
            listPerfil.Items.Clear();
            listPerfil.Items.AddRange(dao3.Select().ToArray());

            pbConfirmEmail.Visible = false;
            pbConfirmLogin.Visible = false;
            pbConfirmSenha.Visible = false;
            pbErrorEmail.Visible = false;
            pbErrorLogin.Visible = false;
            pbErrorSenha.Visible = false;

            if (PessoaLogada.Instance.Perfil.Nome.Equals("Administrador"))
            {
                if (isAlter)
                {
                    if (MessageManager.idiomaAtual.Equals("pt-BR"))
                    {
                        btnSave.Text = "Salvar";
                        btnDelete.Text = "Excluir";
                    }
                    else
                    {
                        btnSave.Text = "Save";
                        btnDelete.Text = "Delete";
                    }
                }
                else
                {
                    if (MessageManager.idiomaAtual.Equals("pt-BR"))
                    {
                        btnSave.Text = "Cadastrar";
                        btnDelete.Text = "Voltar";
                    }
                    else
                    {
                        btnSave.Text = "Register";
                        btnDelete.Text = "Back";
                    }
                }
            }
            else
            {
                lbPerfil.Visible = false;
                listPerfil.Visible = false;

                if (MessageManager.idiomaAtual.Equals("pt-BR"))
                {
                    btnSave.Text = "Cadastrar";
                    btnDelete.Text = "Voltar";
                }
                else
                {
                    btnSave.Text = "Register";
                    btnDelete.Text = "Back";
                }
            }
        }

        private void VerificaStatus()
        {
            MessageRegisterPerson message = new MessageRegisterPerson();
            login = message.E_VERIFICA_NOME(tbLogin.Text);
            email = message.E_VERIFICA_EMAIL(tbEmail.Text);
            senha = message.E_VERIFICA_SENHA(tbPassword.Text);

            if (login)
            {
                //Verde
                pbConfirmLogin.Visible = true;
                pbErrorLogin.Visible = false;
                tbLogin.BackColor = Color.White;
            }
            else
            {
                //Vermelho
                pbConfirmLogin.Visible = false;
                pbErrorLogin.Visible = true;
                tbLogin.BackColor = Color.Red;
            }

            if (email)
            {
                //Verde
                pbConfirmEmail.Visible = true;
                pbErrorEmail.Visible = false;
            }
            else
            {
                //Vermelho
                pbConfirmEmail.Visible = false;
                pbErrorEmail.Visible = true;
            }

            if (senha)
            {
                //Verde
                pbConfirmSenha.Visible = true;
                pbErrorSenha.Visible = false;
            }
            else
            {
                //Vermelho
                pbConfirmSenha.Visible = false;
                pbErrorSenha.Visible = true;
            }

            if (login && email && senha)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaStatus();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaStatus();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PessoaDAO dao = new PessoaDAO();

            Perfil per = (Perfil) listPerfil.SelectedItem;
            Idioma idi = (Idioma) cbLanguage.SelectedItem;

            if (isAlter)
            {
                pessoaAtual.Nome = tbName.Text;
                pessoaAtual.Email = tbEmail.Text;
                pessoaAtual.Telefone = tbPhone.Text;
                pessoaAtual.Login = tbLogin.Text;
                pessoaAtual.Senha = tbPassword.Text;
                pessoaAtual.IdPerfil = per.Id;
                pessoaAtual.IdIdioma = idi.Id;

                dao.Edit(pessoaAtual);

                this.Close();
            }
            else
            {
                if (PessoaLogada.Instance.Perfil.Nome.Equals("Administrador"))
                {
                    dao.Add(new Pessoa()
                    {
                        Nome = tbName.Text,
                        Email = tbEmail.Text,
                        Telefone = tbPhone.Text,
                        Login = tbLogin.Text,
                        Senha = tbPassword.Text,
                        IdPerfil = per.Id,
                        IdIdioma = idi.Id,
                        Ativa = true
                    });

                    this.Close();
                }
                else
                {

                    Perfil per2 = new Perfil();
                    foreach (Perfil p in new PerfilDAO().Select())
                    {
                        if (p.Nome.Equals("Cliente"))
                        {
                            per2 = p;
                        }
                    }

                    dao.Add(new Pessoa()
                    {
                        Nome = tbName.Text,
                        Email = tbEmail.Text,
                        Telefone = tbPhone.Text,
                        Login = tbLogin.Text,
                        Senha = tbPassword.Text,
                        IdPerfil = per2.Id,
                        IdIdioma = idi.Id,
                        Ativa = true
                    });

                    this.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PessoaDAO dao = new PessoaDAO();

            if (isAlter)
            {
                pessoaAtual.Ativa = false;

                dao.Desabilita(pessoaAtual);
            }
            else
            {
                this.Close();
            }
        }
    }
}
