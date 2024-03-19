using Project.Database.Repositories;
using Task = Project.Database.Entities.Task;

namespace Project.Core.Services
{
    public class TasksService
    {
        private TasksRepository tasksRepository { get; set; }

        public TasksService(TasksRepository tasksRepository)
        {
            this.tasksRepository = tasksRepository;
        }

        public List<Task> GetTasks() 
        { 
            var results = tasksRepository.GetTasks();


            return results;
        }

        public Task GetTaskDetails(int taskId)
        {
            var tasks = tasksRepository.GetTasks();

            var result = tasks.Where(e => e.Id == taskId).FirstOrDefault(); 

            return result;
        }
    }
}
