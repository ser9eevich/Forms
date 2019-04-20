using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barbershop;

namespace BarberShopForms
{
    public partial class AddClient : Form
    {
        private List<Client> Clients;
        private ListBox ClientListBox;
        public AddClient(List<Client> clients, ListBox clientListBox)
        {
            Clients = clients;
            ClientListBox = clientListBox;
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && phoneTextBox.Text != "")
            {
                var client = new Client()
                {
                    ClientName = nameTextBox.Text,
                    Birthday = dateTimePicker.Value,
                    PhoneNumber = phoneTextBox.Text,
                };

                Clients.Add(client);
                ClientListBox.DataSource = null;
                ClientListBox.DataSource = Clients;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
