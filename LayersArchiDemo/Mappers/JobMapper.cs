using API.Models.DTO;
using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;

namespace API.Mappers
{
    public static class JobMapper
    {

        public static JobDTO ToJobDTO(this Job job)
        {
            return new JobDTO
            {
                Id = job.Id,
                Name = job.Name,
                Sector = job.Sector,
                MinimalSalary = job.MinimalSalary,
                CP = job.CP,
            };
        }

        public static CreateJobForm ToCreateJobForm(this Job job)
        {
            return new CreateJobForm()
            {
                Name = job.Name,
                Sector = job.Sector,
                MinimalSalary = job.MinimalSalary,
                CP = job.CP,
            };
        }
    }
}
