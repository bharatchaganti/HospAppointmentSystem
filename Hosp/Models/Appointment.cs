namespace Hosp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int PatientId { get; set; }
        [Required, Display(Name = "Patient name")]
        public string PatientName { get; set; }
        [Required, Display(Name = " Doctor name")]
        public string DoctorName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }
        [Required, Display(Name = "Health problem")]
        public string HealthProblem { get; set; }
    }
}
