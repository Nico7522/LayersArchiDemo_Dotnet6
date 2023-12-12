using LayersArchiDemo_DAL.Context;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Repository
{
    public class JobRepository : IJobRepository
    {
        public Job? Create(Job elem)
        {
            elem.Id = FakeDB.Jobs.Max(j => j.Id) + 1;
            FakeDB.Jobs.Add(elem);
            return elem;
        }

        public bool Delete(Job elem)
        {
            FakeDB.Jobs.Remove(elem);
            return true;
        }

        public IEnumerable<Job> GetAll()
        {
            return FakeDB.Jobs;
        }

        public Job? GetById(int id)
        {
            Job? job = FakeDB.Jobs.Where(j => j.Id == id).FirstOrDefault();
            return job;
        }

        public bool Update(Job elem)
        {
            Console.WriteLine(elem.Name);
            int index = FakeDB.Jobs.FindIndex(j => j.Id == elem.Id);
            if (index == -1) return false;
            FakeDB.Jobs[index] = elem;

            return true;
        }
    }
}
