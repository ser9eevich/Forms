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
    public partial class EditClient : Form
    {
        private Client Client;
        private List<Client> Clients;
        private ListBox ClientsListBox;
        public EditClient(Client client, List<Client> clients, ListBox listbox)
        {
            Client = client;
            Clients = clients;
            ClientsListBox = listbox;
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Client.ClientName != nameTextBox.Text && nameTextBox.Text != "")
                Client.ClientName = nameTextBox.Text;

            if (Client.PhoneNumber != phoneTextBox.Text && phoneTextBox.Text != "")
                Client.PhoneNumber = phoneTextBox.Text;

            if (Client.Birthday.Day != dateTimePicker.Value.Day ||
                Client.Birthday.Month != dateTimePicker.Value.Month ||
                Client.Birthday.Year != dateTimePicker.Value.Year)
                Client.Birthday = dateTimePicker.Value;

            ClientsListBox.DataSource = null;
            ClientsListBox.DataSource = Clients;
            this.Close();
        }
    }
}
