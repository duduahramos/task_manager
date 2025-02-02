using System.ComponentModel;

namespace TaskManagerApi.Enums
{
    public enum UserTaskStatus
    {
        [Description("Sem status")]
        NoStatus = 0,
        [Description("Em andamento")]
        InProgress = 1,
        [Description("Concluída")]
        Completed = 2,
        [Description("Cancelada")]
        Canceled = 3
    }
}