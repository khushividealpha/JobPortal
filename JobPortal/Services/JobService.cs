using JobPortal.Data;
using JobPortal.Models;

namespace JobPortal.Services
{
    public class JobService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public JobService(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        //create job
        public async Task<JobModel> CreateJob(JobModel job)
        {
            try
            {
                //check if company exists
                var company = await _context.Company.FindAsync(job.CompanyId);
                if (company == null)
                {
                    throw new Exception($"company with Id {job.CompanyId} does not exist");
                }
                job.PostedDate= DateTime.Now;
                _context.Add(job);
                _context.SaveChanges();
                return job;

            }
            catch 
            {
                throw new Exception("Create Job Failed");
            }

        }
    }
}
