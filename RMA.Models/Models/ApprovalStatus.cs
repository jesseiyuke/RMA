using System.ComponentModel.DataAnnotations;

namespace RMA.Models
{
    public class ApprovalStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}