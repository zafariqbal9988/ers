using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CaseForms
    {
        public long ID { get; set; }
        public long? StudentId { get; set; }
        public string? CivilId { get; set; }
        public long? Age { get; set; }
        public string? SchoolName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Nationality { get; set; }
        public DateOnly? DateOfAssessment { get; set; }
        public string? ReasonForAdmission { get; set; }
        public long? ParentsMobile { get; set; }
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
