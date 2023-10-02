using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMA.Models
{
    public class Admin
    {
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }
        public bool IsActive { get; set; }
    }
}