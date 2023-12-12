using API.Mappers;
using API.Models.DTO;
using LayersArchiDemo_BLL.Interfaces;
using LayersArchiDemo_BLL.Mappers;
using LayersArchiDemo_BLL.Models.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<JobDTO>> GetAll()
        {
            List<JobDTO> jobs = _jobService.GetAll().Select(j => j.ToJobDTO()).ToList();
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public ActionResult<JobDTO> GetById(int id)
        {
            JobDTO? job = _jobService.GetById(id)?.ToJobDTO();
            if (job is null) return BadRequest();

            return Ok(job);
        }

        [HttpPost]
        public ActionResult<JobDTO> Create(CreateJobForm form)
        {
            JobDTO? newJob = _jobService.Create(form)?.ToJobDTO();
            if(newJob is null) return BadRequest();

            return Ok(newJob);

        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, UpdateJobForm form) {

           bool isUpdated = _jobService.Update(id, form);
            if (!isUpdated) return BadRequest();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool IsDeleted = _jobService.Delete(id);
            if (!IsDeleted) return BadRequest();

            return NoContent();
        }
    }
}
