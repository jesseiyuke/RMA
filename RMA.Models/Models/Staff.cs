using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Staff
    {

        [Required]
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [DisplayName("Company")]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; }


        [Required]
        [DisplayName("ApprovalStatus")]
        public int ApprovalStatusId { get; set; }
        [ForeignKey("ApprovalStatusId")]
        [ValidateNever]
        public ApprovalStatus ApprovalStatus { get; set; }
    }
}