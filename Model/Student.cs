using System;
namespace BlazorApp1.Model

{
    public class Student
    {
        public int Id { get; set; }
        public string RollNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
       
        public DateTime? DateOfBirth { get; set; }
       
        public string PermanentEducationNumber { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string GuardianName { get; set; } = string.Empty;
        public string AadharNumber { get; set; } = string.Empty;
        public string NameOnAadhar { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string AlternateMobileNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MotherTongue { get; set; } = string.Empty;
        public string SocialCategory { get; set; } = string.Empty;
        public string MinorityGroup { get; set; } = string.Empty;
        public string IsBPLBeneficiary { get; set; }
        public string IsAAYBeneficiary { get; set; }
        public string IsEWS { get; set; }
        public string IsCWSN { get; set; }
        public string TypeOfImpairment { get; set; } = string.Empty;
        public string IsIndian { get; set; }
        public string IsOutOfSchool { get; set; }
        public DateTime? MainstreamDate { get; set; }
        public string HasDisabilityCertificate { get; set; }
        public decimal DisabilityPercentage { get; set; }
        public string BloodGroup { get; set; } = string.Empty;
    }

}
