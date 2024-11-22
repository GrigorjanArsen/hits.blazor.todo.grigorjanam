using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class ProjectItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; } //  ? - может быть Null
        [Required]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }

        public DateTime? RegisteredDate { get; set; }

    }
}
