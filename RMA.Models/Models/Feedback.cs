using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Issue")]
        public string IssueId { get; set; }
        [ForeignKey("IssueId")]
        [ValidateNever]
        public Issue Issue { get; set; }
        public string Name { get; set; }

        [Required]
        [Display(Name = "DateReported")]
        [DataType(DataType.Date)]
        public DateTime? DateReported { get; set; }

        [Required]
        [DisplayName("IssueStatus")]
        public int IssueStatusId { get; set; }
        [ForeignKey("IssueStatusId")]
        [ValidateNever]
        public IssueStatus IssueStatus { get; set; }

    }
}