using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipApp.Controllers;
using TipApp.Models;

namespace TipApp
{
    public partial class AddWorkerForm : Form
    {
        Controller WorkerController = new Controller();

        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void AddWorkerConfirm_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker()
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                RegistrationNumber = VehicleNumber.Text
            };
            WorkerController.AddWorker(worker);
            this.Close();
        }
    }
}
