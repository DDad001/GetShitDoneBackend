using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GetShitDoneBackend.Models;
using GetShitDoneBackend.Services;

namespace GetShitDoneBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectItemController : ControllerBase
    {
        private readonly ProjectItemService _data;

        public ProjectItemController(ProjectItemService dataFromService) {
            _data = dataFromService;
        }

        // Add a new ProjectItemModel.cs to table
        [HttpPost("AddProjectItem")]
        public bool AddProjectItem(ProjectItemModel newProjectItem)
        {
            return _data.AddProjectItem(newProjectItem);
        }

        // Get all ProjectItems from table
        [HttpGet("GetAllProjectItems")]
        public IEnumerable<ProjectItemModel> GetAllProjectItems()
        {
            return _data.GetAllProjectItems();
        }

        // Get a ProjectItem by the specific id set to a ProjectItem
        [HttpGet("GetProjectItemById/{Id}")]
        public ProjectItemModel GetProjectItemsById(int id)
        {
            return _data.GetProjectItemsById(id);
        }

        // Get a LIST of ProjectItems by a specific userId
        [HttpGet("GetProjectItemsByUserId/{UserId}")]
        public IEnumerable<ProjectItemModel> GetItemsByUserId(int userId)
        {
            return _data.GetProjectItemsByUserId(userId);
        }

        // Get a ProjectItem by the title of a ProjectItem 
        [HttpGet("GetProjectItemByTitle/{Title}")]
        public IEnumerable<ProjectItemModel> GetProjectItemByTitle(string title)
        {
            return _data.GetProjectItemByTitle(title);
        }

        // Get a ProjectItem by the description of a ProjectItem
        [HttpGet("GetProjectItemByDescription/{Description}")]
        public IEnumerable<ProjectItemModel> GetProjectItemByDescription(string description)
        {
            return _data.GetProjectItemByDescription(description);
        }

        // Get a ProjectItem by the dateCreated of a ProjectItem 
        [HttpGet("GetProjectItemByDateCreated/{DateCreated}")]
        public IEnumerable<ProjectItemModel> GetProjectItemByDateCreated(string dateCreated)
        {
            return _data.GetProjectItemByDateCreated(dateCreated);
        }

        // Get a ProjectItem by the dueDate of a ProjectItem 
        [HttpGet("GetProjectItemByDueDate/{DueDate}")]
        public IEnumerable<ProjectItemModel> GetProjectItemByDueDate(string dueDate)
        {
            return _data.GetProjectItemByDueDate(dueDate);
        }

        // Get all ProjectItems by status. (E.g "GetProjectItemByStatus/toDo")
        [HttpGet("GetProjectItemsByStatus/{Status}")]
        public IEnumerable<ProjectItemModel> GetProjectItemsByStatus(string status)
        {
            return _data.GetProjectItemsByStatus(status);
        }

        // Get a LIST of all ProjectItems you are a member of by memberId
        [HttpGet("GetProjectItemsByAMemberId/{MemberId}")]
        public IEnumerable<ProjectItemModel> GetProjectItemsByAMemberId(string memberId)
        {
            return _data.GetProjectItemsByAMemberId(memberId);
        }

        // Get a LIST of all ProjectItems you are a member of by memberUsername
        [HttpGet("GetProjectItemByAMemberUsername/{MemberUsername}")]
        public IEnumerable<ProjectItemModel> GetProjectItemsByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemsByAMemberUsername(memberUsername);
        }

        // Get all soft deleted ProjectItems 
        [HttpGet("GetDeletedProjectItems")]
        public IEnumerable<ProjectItemModel> GetDeletedProjectItems()
        {
            return _data.GetDeletedProjectItems();
        }

        // Get all archived ProjectItems
        [HttpGet("GetArchivedProjectItems")]
        public IEnumerable<ProjectItemModel> GetArchivedProjectItems()
        {
            return _data.GetArchivedProjectItems();
        }

        // This is the endpoint front end will use to push a new member to the 
        // string[] MembersUsername array.
        // 
        // This will update the entire project, so it will take in a model that must contain
        // every required field to make the ProjectItemModel.cs
        [HttpPost("UpdateProjectItem")]
        public bool UpdateProjectItem(ProjectItemModel updatedProject)
        {
            return _data.UpdateProjectItem(updatedProject);
        }

        // Soft delete a ProjectItem
        [HttpPost("DeleteProjectItem")]
         public bool DeleteProjectItem (ProjectItemModel deletedProject)
        {
           return _data.DeleteProjectItem(deletedProject);
        }

    }
}