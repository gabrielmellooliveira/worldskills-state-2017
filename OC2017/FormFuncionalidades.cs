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
    public partial class FormFuncionalidades : Form
    {
        Perfil p;
        public FormFuncionalidades(Perfil perfil)
        {
            InitializeComponent();
            lbPerfil.Text = perfil.Nome;
            p = perfil;
        }
        
        private void FormFuncionalidades_Load(object sender, EventArgs e)
        {
            listFuncionalidades.Clear();
            listFuncionalidades.Columns.Insert(0, "Nome", 300, HorizontalAlignment.Center);
            listFuncionalidades.Columns.Insert(1, "Url", 300, HorizontalAlignment.Center);

            FuncionalidadeDAO dao = new FuncionalidadeDAO();
            foreach (Funcionalidade funcionalidade in dao.Select())
            {
                if (funcionalidade.IdPerfil == p.Id)
                {
                    ListViewItem listItem = listFuncionalidades.Items.Add(funcionalidade.Nome);
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionalidade.Url));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Funcionalidade f = new Funcionalidade()
            {
                Nome = tbName.Text,
                Url = tbUrl.Text,
                IdPerfil = p.Id
            };

            FuncionalidadeDAO dao = new FuncionalidadeDAO();
            dao.Add(f);

            p.Funcionalidades.Add(f);

            PerfilDAO dao2 = new PerfilDAO();
            dao2.Edit(p);

            listFuncionalidades.Clear();
            listFuncionalidades.Columns.Insert(0, "Nome", 300, HorizontalAlignment.Center);
            listFuncionalidades.Columns.Insert(1, "Url", 300, HorizontalAlignment.Center);

            FuncionalidadeDAO dao3 = new FuncionalidadeDAO();
            foreach (Funcionalidade funcionalidade in dao3.Select())
            {
                if (funcionalidade.IdPerfil == p.Id)
                {
                    ListViewItem listItem = listFuncionalidades.Items.Add(funcionalidade.Nome);
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionalidade.Url));
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FuncionalidadeDAO dao = new FuncionalidadeDAO();

            /*foreach (ListViewItem f in listFuncionalidades.CheckedItems)
            {
                f.IdPerfil = 0;
                dao.Edit(f);
            }

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
            }*/
        }
       
    }
}
