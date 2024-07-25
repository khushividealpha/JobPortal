﻿namespace JobPortal.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; }
        public string Owner { get; set; } = "";
    }
}
