using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetShitDoneBackend.Models;
using GetShitDoneBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetShitDoneBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskItemController : ControllerBase
    {
        private readonly TaskItemService _data;
        //variable _data is to access all the functions from service    
        //we don't want to manipulate the service, thats why we want it to be read only 
        //now data will have acccess to all the functions in the folder

        public TaskItemController(TaskItemService dataFromService)
        {
            _data = dataFromService;
        }

        // Add a new TaskItem
        [HttpPost("AddTaskItem")]
        public bool AddTaskItem(TaskItemModel newTaskItem)
        {
            return _data.AddTaskItem(newTaskItem);
        }

        // Get a LIST of all TaskItems
        [HttpGet("GetAllTaskItems")]
        public IEnumerable<TaskItemModel> GetAllTaskItems()
        {
            return _data.GetAllTaskItems();
        }


        [HttpGet("GetTaskItemsByeUserID/{UserID}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByUserID(int UserID)
        {
            return _data.GetTaskItemsByUserID(Id);
        }

        [HttpGet("GetTaskItemsByProjectID/{ProjectID}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByProjectID(int ProjectID)
        {
            return _data.GetTaskItemsByProjectID(UserID);
        }

        [HttpGet("GetTaskByTitle/{Title}")]
        public IEnumerable<TaskItemModel> GetTaskByTitle(string Title)
        {
            return _data.GetTaskByTitle(Title);
        }

        [HttpGet("GetTaskByDescription/{Description}")]
        public List<TaskItemModel> GetTaskByDescription(string Description)
        {
            return _data.GetTaskByDescription(Description);
        }

        [HttpGet("GetTaskByDateCreated/{DateCreated}")]
        public IEnumerable<TaskItemModel> GetTaskByDateCreated(string DateCreated)
        {
            return _data.GetTaskByDateCreated(DateCreated);
        }

        [HttpGet("GetTaskByDueDate")]
        public IEnumerable<TaskItemModel> GetTaskByDueDate()
        {
            return _data.GetTaskByDueDate();
        }

        [HttpGet("GetTaskPriorityItems")]
        public IEnumerable<TaskItemModel> GetTaskPriorityItems()
        {
            return _data.GetTaskPriorityItems();
        }

        [HttpGet("GetTaskAssignees")]
        public IEnumerable<TaskItemModel> GetTaskAssignees()
        {
            return _data.GetTaskAssignees();
        }

        [HttpGet("GetTaskStatus")]
        public IEnumerable<TaskItemModel> GetTaskStatus()
        {
            return _data.GetTaskStatus();
        }

        [HttpPost("UpdateTaskItem")]
        public bool UpdateTaskItem(TaskItemModel TaskUpdate)
        {
            return _data.UpdateTaskItem(TaskUpdate);
        }

        [HttpPost("DeleteTaskItem")]
        public bool DeleteTaskItem(TaskItemModel TaskDelete)
        {
            return _data.DeleteTaskItem(TaskDelete);
        }

    }
}