using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; } //  ? - может быть Null
        [Required]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }

        public int? ProjId { get; set; }
        [ForeignKey("ProjId")]
        public ProjectItem Proj { get; set; }
    }
}
