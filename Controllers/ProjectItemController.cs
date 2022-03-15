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
            return _data.AddprojectItem(newProjectItem);
        }

        // Get all ProjectItems from table
        [HttpGet("GetAllProjectItems")]
        public IEnumerable<ProjectItemModel> GetAllProjectItem()
        {
            return _data.GetAllProjectItems();
        }

        // Get a ProjectItem by the specific id set to a ProjectItem
        [HttpGet("GetProjectItemById/{Id}")]
        public ProjectItemModel GetItemsById(int id)
        {
            return _data.GetItemsById(id);
        }

        // Get a LIST of ProjectItems by a specific userId
        [HttpGet("GetProjectItemsByUserId/{UserId}")]
        public IEnumerable<ProjectItemModel> GetItemsByUserId(int userId)
        {
            return _data.GetItemsByUserId(userId);
        }

        // Get a ProjectItem by the title of a ProjectItem 
        [HttpGet("GetProjectItemByTitle/{Title}")]
        public ProjectItemModel GetProjectItemByTitle(string title)
        {
            return _data.GetProjectItemByTitle(title);
        }

        // Get a ProjectItem by the description of a ProjectItem
        [HttpGet("GetProjectItemByDescription/{Description}")]
        public ProjectItemModel GetProjectItemByDescription(string description)
        {
            return _data.GetProjectItemByDescription(description);
        }

        // Get a ProjectItem by the dateCreated of a ProjectItem 
        [HttpGet("GetProjectItemByDateCreated/{DateCreated}")]
        public ProjectItemModel GetProjectItemByDateCreated(string dateCreated)
        {
            return _data.GetProjectItemByDateCreated(dateCreated);
        }

        // Get a ProjectItem by the dueDate of a ProjectItem 
        [HttpGet("GetProjectItemByDueDate/{DueDate}")]
        public ProjectItemModel GetProjectItemByDueDate(string dueDate)
        {
            return _data.GetProjectItemByDueDate(dueDate);
        }

        // Get all ProjectItems by status. (E.g "GetProjectItemByStatus/toDo")
        [HttpGet("GetProjectItemByStatus/{Status}")]
        public IEnumerable<ProjectItemModel> GetProjectItemByStatus(string status)
        {
            return _data.GetProjectItemByStatus(status);
        }

        // Get a ProjectItem by a specific memberId
        [HttpGet("GetProjectItemByAMemberId/{MemberId}")]
        public ProjectItemModel GetProjectItemByAMemberId(int memberId)
        {
            return _data.GetProjectItemByAMemberId(memberId);
        }

        // Get a ProjectItem by a specific memberUsername
        [HttpGet("GetProjectItemByAMemberUsername/{MemberUsername}")]
        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemByAMemberUsername(memberUsername);
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