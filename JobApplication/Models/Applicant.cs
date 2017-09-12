using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobApplication.Models
{
    public class Applicant
    {

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Please enter a valid Social Security number")]
        [Display(Name = "Social Security Number")]
        public string SSN { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Cell Phone #")]
        public string CellPhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Personal Website/LinkedIn")]
        public string PersonalWebsite { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Current Employer")]
        public string CurrentEmployerName { get; set; }

        [Display(Name = "Current Job Title")]
        public string CurrentJobTitle { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Address")]
        public string EmployerAddress { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "City")]
        public string EmployerCity { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "State")]
        public string EmployerState { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(5, MinimumLength = 5)]
        [RegularExpression("([0-9][0-9][0-9][0-9][0-9]*)")]
        [Display(Name = "Zip Code")]
        public string EmployerZipCode { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Previous Employer")]
        public string Previous1Employer { get; set; }

        [Display(Name = "Previous Employer")]
        public string Previous2Employer { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Title")]
        public string Previous1Title { get; set; }

        [Display(Name = "Title")]
        public string Previous2Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone #")]
        public string EmployerPhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone #")]
        public string Previous1PhoneNumber { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone #")]
        public string Previous2PhoneNumber { get; set; }

        [Range(0, 100)]
        [Display(Name = "Years at Employer")] //set up range so that it's a positive whole number.
        public int YearsatEmployer { get; set; }

        [Range(0, 100)]
        [Display(Name = "Years at Employer")] //set up range so that it's a positive whole number.
        public int YearsatPrev1Employer { get; set; }

        [Range(0, 100)]
        [Display(Name = "Years at Employer")] //set up range so that it's a positive whole number.
        public int YearsatPrev2Employer { get; set; }


        [Range(0.0, Double.MaxValue)]
        [Display(Name = "Annual Sales")]
        public int AnnualSales { get; set; }


        //Application Signature

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Name")]
        public string PrintedSignatureName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Title")]
        public string SignatureTitle { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime SignatureDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Display(Name = "Signature")]
        public string Signature { get; set; }

        //Background Check Information
        [Display(Name = "Have you filed bankruptcy in the last ten (10) years?")]
        public string BankruptcyFlag { get; set; } //set up range validation
        [Display(Name = "County")]
        public string BankruptcyCounty { get; set; }
        [Display(Name = "State")]
        public string BankruptcyState { get; set; }
        [Display(Name = "Bankruptcy Status")]
        public string BankruptcyStatus { get; set; } //dropdown list?
        [Display(Name = "Do you have any outstanding Federal, State or Local taxes?")]
        public string TaxFlag { get; set; }
        [Display(Name = "Explain Details: ")]
        public string TaxExplanation { get; set; }
        [Display(Name = "Have you been convicted of, or pled guilty or no contest to any crime in the last ten (10) years?")]
        public string CrimeFlag { get; set; }


    }


}
