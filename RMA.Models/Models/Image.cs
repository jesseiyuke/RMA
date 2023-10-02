using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        [Required]
        [DisplayName("Issue")]
        public string IssueId { get; set; }
        [ForeignKey("IssueId")]
        [ValidateNever]
        public Issue Issue { get; set; }
    }
}