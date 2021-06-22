using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA
{
    public class StudentStatusMetadata
    {
        public int SSID { get; set; }

        [Required]
        [Display(Name = "Status")]
        [StringLength(30, ErrorMessage = "Maximum length is 30 characters.")]
        public string SSName { get; set; }

        [Display(Name = "Description")]
        [StringLength(250, ErrorMessage = "Maximum length is 250 characters.")]
        public string SSDescription { get; set; }
    }

    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
}
