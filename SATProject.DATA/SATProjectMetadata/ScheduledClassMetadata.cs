using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA
{
    public class ScheduledClassMetadata
    {
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage = "Maximum length is 40 characters.")]
        public string InstructorName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string Location { get; set; }

        [Required]
        public int SCSID { get; set; }

        [Display(Name = "Class Info")]
        public string classInfo { get; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {

        public string classInfo
        {
            get { return String.Format($"Start Date: {StartDate:d} Course: {CourseId} Location: {Location}"); }
        }
    }
}
