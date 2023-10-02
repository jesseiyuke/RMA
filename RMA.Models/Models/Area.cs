using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [DisplayName("Company")]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; }
    }
}