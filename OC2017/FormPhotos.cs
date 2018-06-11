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
    public partial class FormPhotos : Form
    {
        public static List<Foto> FOTOS = new List<Foto>();

        public FormPhotos()
        {
            InitializeComponent();
        }

        private void FormPhotos_Load(object sender, EventArgs e)
        {
            lbEvent.Text = FormRegisterEvents.EVENTO.Nome;

            listPhotos.Clear();
            listPhotos.Columns.Insert(0, "Descricao", 300, HorizontalAlignment.Center);
            listPhotos.Columns.Insert(1, "Foto", 300, HorizontalAlignment.Center);
            
            foreach (Foto foto in FOTOS)
            {
                ListViewItem listItem = listPhotos.Items.Add(foto.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, foto.Url));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FOTOS.Add(new Foto() {
                Nome = tbDescription.Text,
                Url = tbPhoto.Text
            });

            listPhotos.Clear();
            listPhotos.Columns.Insert(0, "Descricao", 300, HorizontalAlignment.Center);
            listPhotos.Columns.Insert(1, "Foto", 300, HorizontalAlignment.Center);

            foreach (Foto foto in FOTOS)
            {
                ListViewItem listItem = listPhotos.Items.Add(foto.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, foto.Url));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> Urls = new List<string>();
            foreach (ListViewItem listItem in listPhotos.CheckedItems)
            {
                Urls.Add(listItem.SubItems[1].Text);
            }

            for (int i = 0; i < Urls.Count; i++)
            {
                foreach (Foto foto in FOTOS)
                {
                    if (foto.Url.Equals(Urls[i]))
                    {
                        FOTOS.Remove(foto);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecionar arquivos";
            openFile.Multiselect = true;
            openFile.CheckFileExists = true;
            openFile.DefaultExt = "png";
            openFile.Filter = "Imagens (*.png, *.jpg)|*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string nameFile = openFile.FileName;
                
                tbPhoto.Text = nameFile;
            }
        }
    }
}
