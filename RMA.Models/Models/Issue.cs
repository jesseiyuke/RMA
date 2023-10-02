using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Issue
    {
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [DisplayName("IssueType")]
        public int IssueTypeId { get; set; }
        [ForeignKey("IssueTypeId")]
        [ValidateNever]
        public IssueType IssueType { get; set; }



        [Required]
        [DisplayName("Hazard")]
        public int HazardId { get; set; }
        [ForeignKey("HazardeId")]
        [ValidateNever]
        public Hazard Hazard { get; set; }


        [Required]
        [DisplayName("Area")]
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        [ValidateNever]
        public Area Area { get; set; }


        public string? Risk { get; set; }
        public string? Location { get; set; }

        public string? Description { get; set; }
        public string? ProposedControl { get; set; }

        [Required]
        [Display(Name = "DateReported")]
        [DataType(DataType.Date)]
        public DateTime DateReported { get; set; }
    }
}