using LayersArchiDemo_BLL.Interfaces;
using LayersArchiDemo_BLL.Mappers;
using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;


        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public Job? Create(CreateJobForm form)
        {
            Job? newJob = _jobRepository.Create(form.ToJob());

            if (newJob is null) return null;

            return newJob;
        }

        public bool Delete(int id)
        {
            Job? job = _jobRepository.GetById(id);
            if (job is null) return false;

            bool isDeleted = _jobRepository.Delete(job);
            return true;
        }

        public IEnumerable<Job> GetAll()
        {
            return _jobRepository.GetAll();
        }

        public Job? GetById(int id)
        {
            Job? job = _jobRepository.GetById(id);
            if (job == null) return null;

            return job;
        }

        public bool Update(int id, UpdateJobForm form)
        {

            Job? job = _jobRepository.GetById(id);

            if (job is null) return false;

            Job newJob = new Job()
            {
                Id = job.Id,
                Name = form.Name,
                MinimalSalary = form.MinimalSalary,
                Sector = form.Sector,
                CP = form.CP,
            };
           
            bool isUpdated = _jobRepository.Update(newJob);
            if (!isUpdated) return false;

            return true;
        }
    }
}
