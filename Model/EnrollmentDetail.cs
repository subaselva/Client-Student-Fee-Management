using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class EnrollmentDetail
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; } // Foreign Key
        [Required]
        public int AdmissionNumber { get; set; }
        [Required]
        public DateTime AdmissionDate { get; set; }
        [Required]
        public int ClassRollNo { get; set; }
        [Required]
        public string? MediumOfInstruction { get; set; }

        [Required]
        public string? LanguagesGroupStudied { get; set; }
        [Required]

        public string? AcademicGroupStudied { get; set; }
        [Required]
        public string? SubjectsGroupStudied { get; set; }
        [Required]

        public string? PreviousAcademicYear { get; set; }
        [Required]
        public string? StatusPreviousYear { get; set; }
        [Required]

        public string? Admitted { get; set; }
        [Required]
        public string? PreviousClass { get; set; }
        [Required]

        public string? Marks { get; set; }
        [Required]
        public string? PreviousAttendance { get; set; }

    }

}
