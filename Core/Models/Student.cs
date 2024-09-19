using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    
    public class Student
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public long? AddclassId { get; set; }
        public long? TestTypeId { get; set; }
        public long? SpecialistId { get; set; }
        public long? MobileNo { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public DateTime? Appointment { get; set; }
        public string? Gender { get; set; }
        public string? Reference { get; set; }
        public string? Image { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsBlocked { get; set; }

        // Navigation property for the related products
        public ICollection<CaseForms> CaseForms { get; set; }

        public ICollection<Documents> Documents { get; set; }

        public ICollection<MonitoringList> MonitoringList { get; set; }

        public ICollection<TestReport> TestReport { get; set; }

        public Specialist Specialist { get; set; }

        public TestType TestType { get; set; }

        public Addclass Addclass { get; set; }

    }
}
