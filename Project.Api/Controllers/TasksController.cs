using Microsoft.AspNetCore.Mvc;
using Project.Core.Services;

namespace Project.Api.Controllers
{
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private TasksService tasksService { get; set; }
        private Tasks2Service tasks2Service { get; set; }

        public TasksController(
            TasksService tasksService, 
            Tasks2Service tasks2Service)
        {
            this.tasksService = tasksService;
            this.tasks2Service = tasks2Service;
        }

        [HttpGet]
        [Route("get-tasks")]
        public IActionResult GetTasks()
        {
            var results = tasksService.GetTasks();
            results.AddRange(tasks2Service.GetTasks());

            return Ok(results);
        }

        [HttpGet]
        [Route("get-task-details")]
        public IActionResult GetTaskDetails(int taskId)
        {
            var result = tasksService.GetTaskDetails(taskId);

            return Ok(result);
        }
    }
}
