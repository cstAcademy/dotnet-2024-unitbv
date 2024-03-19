using Project.Database.Repositories;
using Task = Project.Database.Entities.Task;

namespace Project.Core.Services
{
    public class Tasks2Service
    {
        private TasksRepository tasksRepository { get; set; }

        public Tasks2Service(TasksRepository tasksRepository)
        {
            this.tasksRepository = tasksRepository;
        }

        public List<Task> GetTasks()
        {
            var results = tasksRepository.GetTasks();

            return results;
        }
    }
}
