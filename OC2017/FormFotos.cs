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
    public partial class FormFotos : Form
    {
        Evento EVENTO = new Evento();

        public FormFotos(Evento evento)
        {
            InitializeComponent();
            EVENTO = evento;
        }

        private void FormFotos_Load(object sender, EventArgs e)
        {
            FotoDAO dao = new FotoDAO();

            foreach (Foto foto in dao.Select())
            {
                if (foto.IdEvento == EVENTO.Id)
                {
                    PictureBox img2 = new PictureBox();
                    img2.Size = new System.Drawing.Size(120, 120);
                    img2.SizeMode = PictureBoxSizeMode.StretchImage;
                    string file = foto.Url;
                    img2.Image = Bitmap.FromFile(@file);

                    Flow.Controls.Add(img2);
                }
            }
        }

        private void Flow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
