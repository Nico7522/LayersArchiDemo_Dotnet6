using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Interfaces
{
    public interface IJobService
    {
        IEnumerable<Job> GetAll();

        Job? Create(CreateJobForm form);

        Job? GetById(int id);

        bool Update(int id, UpdateJobForm form);

        bool Delete(int id);
    }
}
