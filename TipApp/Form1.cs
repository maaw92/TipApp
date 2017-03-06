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
    public partial class Form1 : Form
    {

        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            controller.click();
        }
        private void UpdateList()
        {
            List<Worker> workers = controller.getWorkers();
            foreach (Worker worker in workers)
            {
                this.WorkersList.Items.Add(String.Format("{0} {1}", worker.FirstName, worker.LastName));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UpdateList();
        }
    }
}
