namespace Ced.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventDirector")]
    public partial class EventDirector
    {
        public int EventDirectorId { get; set; }

        public int EventId { get; set; }

        public int ApplicationId { get; set; }

        [Required]
        [StringLength(80)]
        public string DirectorEmail { get; set; }

        [StringLength(100)]
        public string DirectorFullName { get; set; }

        [StringLength(80)]
        public string ADLogonName { get; set; }

        public bool? IsPrimary { get; set; }

        public bool? IsAssistant { get; set; }

        public byte IsAutoGenerated { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual Event Event { get; set; }
    }
}