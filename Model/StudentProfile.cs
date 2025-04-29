using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class StudentProfile
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; } // Foreign Key
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string? FacilitiesProvided { get; set; }
        [Required]
        public string? IsCWSN { get; set; }
        [Required]
        public string? IsSLD { get; set; }
        [Required]
        public string? SLDType { get; set; }
        [Required]
        public string? IsASD { get; set; }
        [Required]
        public string? IsADHD { get; set; }
        [Required]
        public string? IsGifted { get; set; }
        [Required]
        public string? IsInStateCompetition { get; set; }
        [Required]
        public string? IsInNCC_NSS { get; set; }
        [Required]
        public string? IsInUseInternet { get; set; }
        [Required]

        public string? Height { get; set; }
        [Required]

        public string? Weight { get; set; }
        [Required]
        public string? Residencetoschool { get; set; }
        [Required]
        public string? Educationinfamily { get; set; }
    }
}
