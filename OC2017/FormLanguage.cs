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
    public partial class FormLanguage : Form
    {
        public FormLanguage()
        {
            InitializeComponent();
        }

        private void FormLanguage_Load(object sender, EventArgs e)
        {
            listLanguages.Clear();
            listLanguages.Columns.Insert(0, "Nome", 300, HorizontalAlignment.Center);
            listLanguages.Columns.Insert(1, "Sigla", 300, HorizontalAlignment.Center);
            listLanguages.Columns.Insert(1, "Icone", 300, HorizontalAlignment.Center);

            IdiomaDAO dao = new IdiomaDAO();
            foreach (Idioma idioma in dao.Select())
            {
                ListViewItem listItem = listLanguages.Items.Add(idioma.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, idioma.Sigla));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, idioma.Foto));
            }
        }
        string nameFile = "";
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
                nameFile = openFile.FileName;

                pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;

                pbIcon.Image = Bitmap.FromFile(@nameFile);

                tbIcon.Text = nameFile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IdiomaDAO dao = new IdiomaDAO();
            dao.Add(new Idioma() {
                Nome = tbName.Text,
                Sigla = tbSigla.Text,
                Foto = tbIcon.Text
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IdiomaDAO dao = new IdiomaDAO();
            dao.Delete(idiomaSelecionado);
        }

        public static Idioma idiomaSelecionado;
        private void listLanguages_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string sigla = "";
            foreach (ListViewItem listItem in listLanguages.CheckedItems)
            {
                sigla = listItem.SubItems[1].Text;
            }

            IdiomaDAO dao = new IdiomaDAO();
            foreach (Idioma idioma in dao.Select())
            {
                if (idioma.Sigla.Equals(sigla))
                {
                    idiomaSelecionado = idioma;
                }
            }
        }
    }
}
