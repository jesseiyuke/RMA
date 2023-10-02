using System.ComponentModel.DataAnnotations;

namespace RMA.Models
{
    public class IssueStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}