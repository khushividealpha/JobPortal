using JobPortal.Data;
using JobPortal.Models;
using JobPortal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly JobService _jobService;

        public JobController(ApplicationDbContext context,JobService jobService)
        {
            _context = context;
            _jobService = jobService;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateJob([FromBody] JobModel job)
        {
            if (job == null)
            {
                return BadRequest("Job Object is null");
            }

            try
            {
                var company = await _context.Company.FindAsync(job.CompanyId);
                if (company == null) {
                    return BadRequest($"Company with id {job.CompanyId} does not exist");
                }
                var createdJob = await _jobService.CreateJob(job);
                return CreatedAtAction(nameof(createdJob), new { id = createdJob.JobId }, createdJob);

            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
            }

    }
}
