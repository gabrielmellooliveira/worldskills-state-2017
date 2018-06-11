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
    public partial class FormGraphics : Form
    {
        private Evento EVENTO = new Evento();

        public FormGraphics(Evento evento)
        {
            InitializeComponent();
            EVENTO = evento;
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {

        }
    }
}
