using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Interfaces
{
    public interface IJobRepository : IRepositoryBase<int, Job>
    {
    }
}
