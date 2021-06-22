using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA
{
    public class ScheduledClassStatusMetadata
    {
        public int SCSID { get; set; }

        [Required]
        [Display(Name = "Class Status")]
        [StringLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string SCSName { get; set; }
    }

    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
}
