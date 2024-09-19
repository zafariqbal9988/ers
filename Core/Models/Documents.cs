using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Documents
    {
        public long ID { get; set; }
        public long? StudentId { get; set; }
        public string? Photo { get; set; }
        public string? CivilID { get; set; }
        public string? SchoolDocs { get; set; }
        public string? TestReport { get; set; }
        public string? Attendance { get; set; }
        public string? MedicalDocs { get; set; }
        public string? Homework { get; set; }
        public string? TreatmentPlan { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsBlocked { get; set; }

        // Navigation property to the related category
        public Student Student { get; set; }
    }
}
