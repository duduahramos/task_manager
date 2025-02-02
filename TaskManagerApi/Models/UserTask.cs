using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagerApi.Enums;

namespace TaskManagerApi.Models
{
    [Table("UserTasks")]
    public class UserTask
    {
        [Key]
        public Guid TaskId { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskName { get; set; }

        [StringLength(1000)]
        public string TaskDescription { get; set; }

        [Required]
        public UserTaskStatus Status { get; set; } = UserTaskStatus.NoStatus;

        public DateTime DueDate { get; set; }
    }
}
