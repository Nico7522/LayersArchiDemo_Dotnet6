using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Models.Forms
{
    public class CreateJobForm
    {
        public string Name { get; set; }

        public string Sector { get; set; }

        public string CP { get; set; }

        public int MinimalSalary { get; set; }
    }
}
