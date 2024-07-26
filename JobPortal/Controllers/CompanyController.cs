.
using JobPortal.Data;
using JobPortal.Services;

namespace JobPortal.Controllers
{
    public class CompanyController
    {
        private readonly ApplicationDbContext _context;
        private readonly CompanyService _companyService;

        public CompanyController(ApplicationDbContext context,CompanyService companyService)
        {
            _companyService = companyService;
            _context = context;
        }


    }
}
