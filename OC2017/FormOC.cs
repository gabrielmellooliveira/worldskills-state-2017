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
    public partial class FormOC : Form
    {
        Evento EVENTO = new Evento();

        public FormOC()
        {
            InitializeComponent();
        }
        
        private void FormOC_Load(object sender, EventArgs e)
        {

        }

        bool temEvento = false;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            EventoDAO dao1 = new EventoDAO();
            ConviteDAO dao2 = new ConviteDAO();

            foreach (Evento evento in dao1.Select())
            {
                foreach (Convite convite in dao2.Select())
                {
                    if (convite.IdEvento == evento.Id)
                    {
                        if (convite.Email.Equals(tbEmail.Text))
                        {
                            this.EVENTO = evento;
                            temEvento = true;
                        }
                    }
                }
            }

            if (temEvento)
            {
                //Abre tela evento
                Form form = new FormConfirmacao(EVENTO);
                form.Show();
            }
        }
    }
}
