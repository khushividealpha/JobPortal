using JobPortal.Data;
using JobPortal.Models;

namespace JobPortal.Services
{
    public class CompanyService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public CompanyService(IConfiguration configuration,ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<CompanyModel> CreateCompany(CompanyModel company)
        {
            
        }
    }
}
