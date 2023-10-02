using System.ComponentModel.DataAnnotations;

namespace RMA.Models
{
    public class Stats
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}