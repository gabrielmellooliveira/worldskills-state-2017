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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Form form = new FormRegisterEvents();
            form.Show();
        }

        private void btnPerfis_Click(object sender, EventArgs e)
        {
            Form form = new FormPerfis();
            form.Show();
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            Form form = new FormLanguage();
            form.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form form = new FormInfo();
            form.Show();
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            Form form = new FormListPerson();
            form.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (!PessoaLogada.Instance.Perfil.Nome.Equals("Administrador"))
            {
                DesabilitaBotao(btnPerfis);
                DesabilitaBotao(btnIdiomas);
                DesabilitaBotao(btnPessoas);
            }
        }

        private void DesabilitaBotao(Control control)
        {
            control.Enabled = false;
            control.Visible = false;
        }
    }
}
