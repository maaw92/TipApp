using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipApp.Models;
using TipApp.Services;

namespace TipApp.Controllers
{
    class Controller
    {
        
        WorkerService _service = new WorkerService();
        
        public void click()
        {
            new AddWorkerForm().ShowDialog();    
        }
        public void AddWorker(Worker worker)
        {
            _service.AddWorker(worker);
        }

        internal List<Worker> getWorkers()
        {
            return _service.getWorkers();
        }
    }
}
