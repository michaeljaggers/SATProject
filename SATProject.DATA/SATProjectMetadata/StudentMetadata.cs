using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA
{
    public class StudentMetadata
    {
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "Maximum length is 15 characters.")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string Address { get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(10, ErrorMessage = "Maximum length is 10 characters.")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "Maximum length is 13 characters.")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(60, ErrorMessage = "Maximum length is 60 characters.")]
        public string Email { get; set; }

        [Display(Name = "Photo URL")]
        [StringLength(100, ErrorMessage = "Maximum length is 100 characters.")]
        public string PhotoUrl { get; set; }

        [Required]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student { }
}
