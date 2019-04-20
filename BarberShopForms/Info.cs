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
    public partial class Info : Form
    {
        public Client Client;
        public Info(Client client)
        {
            Client = client;
            InitializeComponent();
            name.Text = Client.ClientName;
            birthday.Text = Client.Birthday.ToLongDateString();
            phone.Text = Client.PhoneNumber;
            if (Client.Appointment != null)
            {
                visitDate.Text = Client.Appointment.VisitDate.ToLongDateString();
                service.Text = Service(Client.Appointment.Service);
                worker.Text = Client.Appointment.Worker.WorkerName;
            }
        }

        private string Service(TypeService service)
        {
            switch (service)
            {
                case TypeService.MenHaircut: return "Мужская стрижка";
                case TypeService.HaircutMachine: return "Стрижка машинкой";
                case TypeService.BeardStyling: return "Моделирование бороды";
                case TypeService.BeardСorrection: return "Коррекция бороды";
                case TypeService.HairStyling: return "Укладка волос";
                case TypeService.GreyCamouflage: return "Камуфляж седины";
                case TypeService.PremiumShave: return "Премиум бритье";
                default: return null;
            }
        }
    }
}
