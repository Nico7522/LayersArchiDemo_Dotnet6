using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Mappers
{
    public static class JobMapper
    {
        public static Job ToJob(this CreateJobForm form)
        {
            return new Job()
            {
                Name = form.Name,
                CP = form.CP,
                Sector = form.Sector,
                MinimalSalary = form.MinimalSalary,
            };
        }

    }
}
