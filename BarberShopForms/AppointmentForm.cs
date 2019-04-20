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
    public partial class AppointmentForm : Form
    {
        public Client Client;
        public List<Workers> Workers;
        public AppointmentForm(Client client, List<Workers> workers)
        {
            InitializeComponent();
            Workers = workers;
            workerComboBox.DataSource = Workers;
            Client = client;
        }

        private void MakeAppointment_Click(object sender, EventArgs e)
        {
            if (Client.Appointment != null)
            {
                MessageBox.Show("Клиент уже записан!");
            }
            else
            {
                
                if (serviceComboBox.Text != "" && workerComboBox.Text != "")
                {
                    Client.Appointment = new Appointment();
                    Client.Appointment.VisitDate = dateTimePicker.Value;
                    Client.Appointment.Service = Service(serviceComboBox.Text);
                    Client.Appointment.Worker = FindWorker(workerComboBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните данные!");
                }
            }
        }

        private TypeService Service (string text)
        {
            switch(text)
            {
                case "Мужская стрижка": return TypeService.MenHaircut;
                case "Стрижка машинкой": return TypeService.HaircutMachine;
                case "Моделирование бороды": return TypeService.BeardStyling;
                case "Коррекция бороды": return TypeService.BeardСorrection;
                case "Укладка волос": return TypeService.HairStyling;
                case "Камуфляж седины": return TypeService.GreyCamouflage;
                case "Премиум бритье": return TypeService.PremiumShave;
                default: return TypeService.BeardStyling; // шляпа, потом сделаю нормально
            }
        }

        private Workers FindWorker(string text)
        {
            var name = text.Split(',')[0];
            foreach(var worker in Workers)
            {
                if (name == worker.WorkerName)
                    return worker;
            }
            return null;
        }
    }
}
