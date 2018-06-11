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
    public partial class FormInviteToEvent : Form
    {
        public static List<Convite> CONVITES = new List<Convite>();

        public FormInviteToEvent()
        {
            InitializeComponent();
        }

        private void FormInviteToEvent_Load(object sender, EventArgs e)
        {
            lbEvent.Text = FormRegisterEvents.EVENTO.Nome;

            listInvites.Clear();
            listInvites.Columns.Insert(0, "Nome tratamento", 300, HorizontalAlignment.Center);
            listInvites.Columns.Insert(1, "E-mail", 300, HorizontalAlignment.Center);

            foreach (Convite convite in CONVITES)
            {
                ListViewItem listItem = listInvites.Items.Add(convite.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, convite.Email));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CONVITES.Add(new Convite() {
                Nome = tbName.Text,
                Email = tbEmail.Text
            });

            listInvites.Clear();
            listInvites.Columns.Insert(0, "Nome tratamento", 300, HorizontalAlignment.Center);
            listInvites.Columns.Insert(1, "E-mail", 300, HorizontalAlignment.Center);

            foreach (Convite convite in CONVITES)
            {
                ListViewItem listItem = listInvites.Items.Add(convite.Nome);
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, convite.Email));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> Emails = new List<string>();
            foreach (ListViewItem listItem in listInvites.CheckedItems)
            {
                Emails.Add(listItem.SubItems[1].Text);
            }

            for (int i = 0; i < Emails.Count; i++)
            {
                foreach (Convite convite in CONVITES)
                {
                    if (convite.Email.Equals(Emails[i]))
                    {
                        CONVITES.Remove(convite);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
