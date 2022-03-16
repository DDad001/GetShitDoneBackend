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

        // Get a TaskItem by Id
        [HttpGet("GetTaskItemsById/{Id}")]
        public TaskItemModel GetTaskItemsByID(int id)
        {
            return _data.GetTaskItemsByID(id);
        }

        // Get a LIST of TaskItems by the parent ProjectItem Id
        [HttpGet("GetTaskItemsByProjectID/{ProjectID}")]
        public  IEnumerable<TaskItemModel> GetTaskItemsByProjectID(int ProjectID)
        {
            return _data.GetTaskItemsByProjectID(ProjectID);
        }

        // Get a TaskItem by the Title of TaskItem
        [HttpGet("GetTaskItemByTitle/{Title}")]
        public  IEnumerable<TaskItemModel> GetTaskItemByTitle(string Title)
        {
            return _data.GetTaskItemByTitle(Title);
        }

        // Get a TaskItem by the description of a TaskItem
        [HttpGet("GetTaskItemByDescription/{Description}")]
        public  IEnumerable<TaskItemModel> GetTaskItemByDescription(string Description)
        {
            return _data.GetTaskItemByDescription(Description);
        }

        // Get a LIST of all TaskItems by DateCreated
        [HttpGet("GetTaskItemsByDateCreated/{DateCreated}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByDateCreated(string DateCreated)
        {
            return _data.GetTaskItemsByDateCreated(DateCreated);
        }

        // Get a LIST of all TaskItems by DueDate
        [HttpGet("GetTaskItemsByDueDate/{dueDate}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByDueDate(string dueDate)
        {
            return _data.GetTaskItemsByDueDate(dueDate);
        }

        // Get a LIST of TaskItems by Priority
        [HttpGet("GetTaskItemsByPriority/{priority}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByPriority(string priority)
        {
            return _data.GetTaskItemsByPriority(priority);
        }

        // Get a LIST of all TaskItems by specific Assignee
        [HttpGet("GetTaskItemsByAssignee/{assignee}")]
        public IEnumerable<TaskItemModel> GetTaskItemsByAssignee(string assignee)
        {
            return _data.GetTaskItemsByAssignee(assignee);
        }

        // Get a LIST of all TaskItems by Status
        [HttpGet("GetTaskItemsByStatus/{Status")]
        public IEnumerable<TaskItemModel> GetTaskItemsByStatus(string status)
        {
            return _data.GetTaskItemsByStatus(status);
        }

        // Update a TaskItem
        // This will be used to add an assignee or change title, description, due date, priority or status
        [HttpPost("UpdateTaskItem")]
        public bool UpdateTaskItem(TaskItemModel TaskUpdate)
        {
            return _data.UpdateTaskItem(TaskUpdate);
        }

        // Soft delete a TaskItem
        [HttpPost("DeleteTaskItem")]
        public bool DeleteTaskItem(TaskItemModel TaskDelete)
        {
            return _data.DeleteTaskItem(TaskDelete);
        }
    }
}