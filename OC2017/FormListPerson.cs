using OC2017.DAO;
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
    public partial class FormListPerson : Form
    {
        public FormListPerson()
        {
            InitializeComponent();
        }
        
        private void FormListPerson_Load(object sender, EventArgs e)
        {
            PerfilDAO dao3 = new PerfilDAO();
            cbPerfil.Items.Clear();
            cbPerfil.Items.AddRange(dao3.Select().ToArray());
            cbPerfil.SelectionStart = 1;

            pessoaSelecionada = new Pessoa();

            rbName.Select();

            listPeople.Clear();
            listPeople.Columns.Insert(0, "Nome", 300, HorizontalAlignment.Center);
            listPeople.Columns.Insert(1, "Email", 300, HorizontalAlignment.Center);
            listPeople.Columns.Insert(2, "Telefone", 200, HorizontalAlignment.Center);

            PessoaDAO dao = new PessoaDAO();
            foreach (Pessoa pessoa in dao.Select())
            {
                ListViewItem listItem = listPeople.Items.Add(pessoa.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Email));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Telefone));
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listPeople.Items.Clear();

            PessoaDAO dao = new PessoaDAO();
            foreach (Pessoa pessoa in dao.Select())
            {
                ListViewItem listItem = listPeople.Items.Add(pessoa.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Email));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Telefone));
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listPeople.Items.Clear();

            if (rbName.Checked)
            {
                PessoaDAO dao = new PessoaDAO();
                foreach (Pessoa pessoa in dao.Select())
                {
                    if (pessoa.Nome.Contains(tbFilter.Text.Trim()) && pessoa.Perfil.Nome.Equals(cbPerfil.SelectedItem.ToString()))
                    {
                        ListViewItem listItem = listPeople.Items.Add(pessoa.Nome);
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Email));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Telefone));
                    }
                }
            }
            else
            {
                PessoaDAO dao = new PessoaDAO();
                foreach (Pessoa pessoa in dao.Select())
                {
                    if (pessoa.Email.Contains(tbFilter.Text) && pessoa.Perfil.Nome.Equals(cbPerfil.SelectedItem.ToString()))
                    {
                        ListViewItem listItem = listPeople.Items.Add(pessoa.Nome);
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Email));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, pessoa.Telefone));
                    }
                }
            }
        }

        public static Pessoa pessoaSelecionada;
        private void listPeople_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string email = "";
            foreach (ListViewItem listItem in listPeople.CheckedItems)
            {
                email = listItem.SubItems[1].Text;
            }

            PessoaDAO dao = new PessoaDAO();
            foreach (Pessoa pessoa in dao.Select())
            {
                if (pessoa.Email.Equals(email))
                {
                    pessoaSelecionada = pessoa;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PessoaDAO dao = new PessoaDAO();
            dao.Desabilita(pessoaSelecionada);

            foreach (ListViewItem listItem in listPeople.Items)
            {
                if (listItem.SubItems[1].Text.Equals(pessoaSelecionada.Email))
                {
                    listPeople.Items.Remove(listItem);
                }
            }

            //pessoaSelecionada = new Pessoa();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form form = new FormRegisterPerson();
            form.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Form form = new FormRegisterPerson(pessoaSelecionada);
            form.Show();
        }
    }
}
