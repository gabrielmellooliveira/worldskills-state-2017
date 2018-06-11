using OC2017.Messages;
using OC2017.Model;
using OC2017.Util.Languages;
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
    public partial class FormConfirmacao : Form
    {
        Evento EVENTO = new Evento();

        public FormConfirmacao(Evento evento)
        {
            InitializeComponent();
            EVENTO = evento;
        }

        private void FormConfirmacao_Load(object sender, EventArgs e)
        {
            lbEvento.Text = EVENTO.Nome;
            lbInit.Text = EVENTO.Data_Inicio;
            lbEnd.Text = EVENTO.Data_Fim;

            lbLot1.Text = "R$ " + EVENTO.Lote_1;
            lbHalf1.Text = "R$ " + int.Parse(EVENTO.Lote_1) / 2;
            lbV1.Text = EVENTO.Data_Fim;

            lbLot2.Text = "R$ " + EVENTO.Lote_2;
            lbHalf2.Text = "R$ " + int.Parse(EVENTO.Lote_2) / 2;
            lbV2.Text = EVENTO.Data_Fim;

            lbLot3.Text = "R$ " + EVENTO.Lote_3;
            lbHalf3.Text = "R$ " + int.Parse(EVENTO.Lote_3) / 2;
            lbV3.Text = EVENTO.Data_Fim;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageManager.idiomaAtual.Equals("pt-BR"))
            {
                Language.AjustaCultura(this, "en-US");
                MessageManager.idiomaAtual = "en-US";
            }
            else
            {
                Language.AjustaCultura(this, "pt-BR");
                MessageManager.idiomaAtual = "pt-BR";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new FormFotos(EVENTO);
            form.Show();
        }
    }
}
