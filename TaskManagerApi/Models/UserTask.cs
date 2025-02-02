using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagerApi.Enums;

namespace TaskManagerApi.Models
{
    [Table("UserTasks")]
    public class UserTask
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskName { get; set; }

        [StringLength(1000)]
        public string TaskDescription { get; set; }

        [Required]
        public UserTaskStatus Status { get; set; } = UserTaskStatus.NoStatus;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDateTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDateTime { get; set; }
        public DateTime ClosedDateTime { get; set; }
    }
}
