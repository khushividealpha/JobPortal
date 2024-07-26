using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class JobModel
    {
        public int JobId { get; set; }
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";
        public string CompanyName { get; set; } = "";

        public DateTime PostedDate { get; set; } =DateTime.Now;

        public string EmploymentType { get; set; } = "";
        public string Location { get; set; } = "";

        [Required]
        public string ExperienceLevel { get; set; } = "";// Entry-Level, Mid-Level, Senior-Level, etc.

        [Required]
        public string SalaryRange { get; set; } = "";

        public List<string> Responsibilities { get; set; } = [];

        public List<string> Requirements { get; set; } = []; 

        public List<string> Benefits { get; set; } = []; 

        [StringLength(100)]
        public string ContactEmail { get; set; } = "";

        [StringLength(15)]
        public string ContactPhone { get; set; } = "";

        public DateTime ApplicationDeadLine { get; set; }
        public int CompanyId { get; set; }

    }
}
