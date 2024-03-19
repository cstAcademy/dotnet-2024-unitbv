using Task = Project.Database.Entities.Task;

namespace Project.Database.Repositories
{
    public class TasksRepository
    {
        public TasksRepository()
        {
            Console.WriteLine("TasksRepository here");
        }

        public List<Task> GetTasks()
        {
            return new List<Task>
            {
                new Task { Id = 1, Title = "Task 1" },
                new Task { Id = 2, Title = "Task 2" },
                new Task { Id = 3, Title = "Task 3" },
                new Task { Id = 4, Title = "Task 4" }
            };


        }
    }
}
