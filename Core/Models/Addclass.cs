using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Addclass
    {
        public long ID { get; set; }
        public long Class { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsBlocked { get; set; }

        // Navigation property for the related products
        public ICollection<Student> Student { get; set; }

    }
}
