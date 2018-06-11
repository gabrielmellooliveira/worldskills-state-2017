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
    public partial class FormAddress : Form
    {
        public static Endereco ENDERECO = null;

        public FormAddress()
        {
            InitializeComponent();
        }
        
        private void FormAddress_Load(object sender, EventArgs e)
        {
            lbEvent.Text = FormRegisterEvents.EVENTO.Nome;

            if (ENDERECO != null)
            {
                tbStreet.Text = ENDERECO.Rua;
                tbNumber.Text = ENDERECO.Numero.ToString();
                tbNeighborhood.Text = ENDERECO.Bairro;
                tbState.Text = ENDERECO.Estado;
                tbComplement.Text = ENDERECO.Complemento;
                tbCity.Text = ENDERECO.Cidade;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ENDERECO = new Endereco()
            {
                Rua = tbStreet.Text,
                Numero = int.Parse(tbNumber.Text),
                Complemento = tbComplement.Text,
                Bairro = tbNeighborhood.Text,
                Cidade = tbCity.Text,
                Estado = tbState.Text
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
