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
    public partial class FormInfo : Form
    {
        Evento evento = new Evento();

        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            //Pega todos os eventos e verifica o ano deles
            EventoDAO dao = new EventoDAO();

            List<string> anos = new List<string>();

            foreach (Evento evento in dao.Select())
            {
                string ano = evento.Data_Inicio.Substring(6);
                MessageBox.Show("Ano: " + ano);

                bool igual = false;

                foreach (string a in anos)
                {
                    //Percorre a lista de anos e se tiver algum igual nao adiciona
                    if (a.Equals(ano))
                    {
                        igual = true;
                    }
                }

                if (!igual)
                {
                    anos.Add(ano);
                }
            }

            cbAno.Items.AddRange(anos.ToArray());
            cbEvento.Items.AddRange(dao.Select().ToArray());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            evento = (Evento) cbEvento.SelectedItem;

            Form form = new FormGraphics(evento);
            form.Show();
        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEvento.Items.Clear();

            string anoSelecionado = cbAno.SelectedItem.ToString();
            MessageBox.Show("Ano selecionado: " + anoSelecionado);

            EventoDAO dao = new EventoDAO();

            foreach (Evento evento in dao.Select())
            {
                string ano = evento.Data_Inicio.Substring(6);
                if (anoSelecionado.Equals(ano))
                {
                    cbEvento.Items.Add(evento);
                }
            }
        }
    }
}
