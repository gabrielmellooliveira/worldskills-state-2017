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
    public partial class FormPerfis : Form
    {
        public FormPerfis()
        {
            InitializeComponent();
        }

        public static Perfil perfilSelecionado;
        private void btnFunctions_Click(object sender, EventArgs e)
        {
            Form form = new FormFuncionalidades(perfilSelecionado);
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool exist = false;
            PerfilDAO dao = new PerfilDAO();
            foreach (Perfil per in dao.Select())
            {
                if (per.Nome.Equals(tbName.Text))
                {
                    exist = true;
                }
            }

            if (!exist)
            {
                dao.Add(new Perfil() {
                        Nome = tbName.Text
                });
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool exist = false;
            PessoaDAO dao = new PessoaDAO();
            foreach (Pessoa p in dao.Select())
            {
                if (p.IdPerfil == perfilSelecionado.Id)
                {
                    exist = true;
                }
            }

            if (exist)
            {
                if (MessageManager.idiomaAtual.Equals("pt-BR"))
                {
                    MessageBox.Show("Existe uma pessoa com esse perfil!");
                }
                else
                {
                    MessageBox.Show("There is a person with this profile!");
                }
            }
            else
            {
                PerfilDAO dao2 = new PerfilDAO();
                dao2.Delete(perfilSelecionado);

                foreach (ListViewItem listItem in listPerfis.Items)
                {
                    if (listItem.SubItems[0].Text.Equals(perfilSelecionado.Nome))
                    {
                        listPerfis.Items.Remove(listItem);
                    }
                }
            }
        }

        private void FormPerfis_Load(object sender, EventArgs e)
        {
            listPerfis.Clear();
            listPerfis.Columns.Insert(0, "Nome", 500, HorizontalAlignment.Center);

            PerfilDAO dao = new PerfilDAO();
            foreach (Perfil perfil in dao.Select())
            {
                ListViewItem listItem = listPerfis.Items.Add(perfil.Nome);
            }
        }

        private void listPerfis_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string nome = "";
            foreach (ListViewItem listItem in listPerfis.CheckedItems)
            {
                nome = listItem.SubItems[0].Text;
            }

            PerfilDAO dao = new PerfilDAO();
            foreach (Perfil perfil in dao.Select())
            {
                if (perfil.Nome.Equals(nome))
                {
                    perfilSelecionado = perfil;
                }
            }
        }
    }
}
