using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipApp.Models;

namespace TipApp.Services
{
    class WorkerService
    {
        
        public void AddWorker(Worker worker)
        {
            using (Db _db = new Db())
            {
                _db.Workers.Add(worker);
                _db.SaveChanges();
            }
        }

        internal List<Worker> getWorkers()
        {
            using (Db _db = new Db())
            {
                return _db.Workers.ToList();
            }
        }
    }
}
