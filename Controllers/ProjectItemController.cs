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

        [HttpPost("AddProjectItem")]
        public bool AddProjectItem(ProjectItemModel newProjectItem)
        {
            return _data.AddprojectItem(newProjectItem);
        }

        [HttpGet("GetAllProjectItems")]
        public IEnumerable<ProjectItemModel> GetAllProjectItem()
        {
            return _data.GetAllProjectItems();
        }

        [HttpGet("GetProjectItemById/{Id}")]
        public ProjectItemModel GetItemsById(int id)
        {
            return _data.GetItemsById(id);
        }

        [HttpGet("GetProjectItemsByUserId/{UserId}")]
        public IEnumerable<ProjectItemModel> GetItemsByUserId(int userId)
        {
            return _data.GetItemsByUserId(userId);
        }


        [HttpGet("GetProjectItemByTitle/{Title}")]
        public ProjectItemModel GetBlogItemByTitle(string title)
        {
            return _data.GetBlogItemByTitle(title);
        }

        [HttpGet("GetProjectItemByDescription/{Description}")]
        public ProjectItemModel GetBlogItemByDescription(string description)
        {
            return _data.GetBlogItemByDescription(description);
        }

        [HttpGet("GetProjectItemByDateCreated/{DateCreated}")]
        public ProjectItemModel GetProjectItemByDateCreated(string dateCreated)
        {
            return _data.GetProjectItemByDateCreated(dateCreated);
        }

        [HttpGet("GetProjectItemByDueDate/{DueDate}")]
        public ProjectItemModel GetProjectItemByDueDate(string dueDate)
        {
            return _data.GetProjectItemByDueDate(dueDate);
        }

        [HttpGet("GetProjectItemStatus/{Status}")]
        public ProjectItemModel GetProjectItemStatus(string status)
        {
            return _data.GetProjectItemStatus(status);
        }

        [HttpGet("GetProjectItemByAMemberId/{MemberId}")]
        public ProjectItemModel GetProjectItemByAMemberId(int memberId)
        {
            return _data.GetProjectItemByAMemberId(memberId);
        }

        [HttpGet("GetProjectItemByAMemberUsername/{MemberUsername}")]
        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemByAMemberUsername(memberUsername);
        }

        [HttpGet("GetProjectItemByAMemberUsername/{MemberUsername}")]
        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemByAMemberUsername(memberUsername);
        }

        [HttpGet("GetDeletedProjectItems")]
        public IEnumerable<ProjectItemModel> GetDeletedProjectItems()
        {
            return _data.GetDeletedProjectItems();
        }

        [HttpGet("GetArchivedProjectItems")]
        public IEnumerable<ProjectItemModel> GetArchivedProjectItems()
        {
            return _data.GetArchivedProjectItems();
        }

        // This is the endpoint front end will use 
        [HttpPost("UpdateProjectItem")]
        public bool UpdateProjectItem(ProjectItemModel updatedProject)
        {
            return _data.UpdateProjectItem(updatedProject);
        }
        




















        

        [HttpPost("UpdateBlogItem")]
        public bool UpdateBlogItem (BlogItemModel BlogUpdate)
        {
            return _data.UpdateBlogItem(BlogUpdate);
        }

        [HttpPost("DeleteBlogItem")]
         public bool DeleteBlogItem (BlogItemModel BlogDelete)
        {
           return _data.DeleteBlogItem(BlogDelete);
        }

        [HttpGet("GetBlogItemById/{Id}")]
        public BlogItemModel GetBlogItemById(int Id)
        {
            return _data.GetBlogItemById(Id);
        }


    }
}