using Microsoft.EntityFrameworkCore;
using TaskManagerApi.Models;

namespace TaskManagerApi.Context
{

    public class AppDbContext : DbContext
    {
        public DbSet<UserTask> UserTasks { get; set; }
    }
}
