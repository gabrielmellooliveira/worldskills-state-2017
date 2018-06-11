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
    public partial class FormRegisterEvents : Form
    {
        public static Evento EVENTO = new Evento();

        public FormRegisterEvents()
        {
            InitializeComponent();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            EVENTO.Nome = tbName.Text;
            Form form = new FormPhotos();
            form.Show();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            EVENTO.Nome = tbName.Text;
            Form form = new FormAddress();
            form.Show();
        }

        private void btnInvitePerson_Click(object sender, EventArgs e)
        {
            EVENTO.Nome = tbName.Text;
            Form form = new FormInviteToEvent();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EVENTO.Nome = tbName.Text;
            EVENTO.Descricao = tbDescription.Text;
            EVENTO.Site = tbSite.Text;
            EVENTO.Data_Inicio = tbStart.Text;
            EVENTO.Data_Fim = tbEnd.Text;
            EVENTO.Lote_1 = tbLot1.Text;
            EVENTO.Lote_2 = tbLot2.Text;
            EVENTO.Lote_3 = tbLot3.Text;

            EnderecoDAO ENdao = new EnderecoDAO();

            ENdao.Add(FormAddress.ENDERECO);

            EVENTO.IdEndereco = ENdao.Last().Id;

            EventoDAO Edao = new EventoDAO();

            Edao.Add(EVENTO);

            int IdEvento = Edao.Last().Id;

            FotoDAO Fdao = new FotoDAO();

            foreach (Foto foto in FormPhotos.FOTOS)
            {
                foto.IdEvento = IdEvento;
                Fdao.Add(foto);
            }

            ConviteDAO Cdao = new ConviteDAO();

            foreach (Convite convite in FormInviteToEvent.CONVITES)
            {
                convite.IdEvento = IdEvento;
                Cdao.Add(convite);
            }
        }
    }
}
