using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA
{
    public class CoursMetadata
    {
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Maximum length is 250 characters.")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Maximum length is 500 characters.")]
        public string Notes { get; set; }

        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CoursMetadata))]
    public partial class Cours { }
}
