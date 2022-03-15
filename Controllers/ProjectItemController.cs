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

        [HttpGet("GetProjectItemByMembebr/{Status}")]
        public ProjectItemModel GetProjectItemStatus(string status)
        {
            return _data.GetProjectItemStatus(status);
        }











        [HttpGet("GetBlogItemByDate/{Date}")]
        public ProjectItemModel GetBlogItemByDate(string date)
        {
            return _data.GetBlogItemByDate(date);
        }









        [HttpGet("GetItemsByCategory/{Category}")]
        public IEnumerable<BlogItemModel> GetItemsByCategory(string Category)
        {
            return _data.GetItemsByCategory(Category);
        }

        [HttpGet("GetItemsByTag/{Tag}")]
        public IEnumerable<BlogItemModel> GetItemsByTag(string Tag)
        {
            return _data.GetItemsByTag(Tag);
        }

        [HttpGet("GetItemsByDate/{Date}")]
        public IEnumerable<BlogItemModel> GetItemsByDate(string Date)
        {
            return _data.GetItemsByDate(Date);
        }

        [HttpGet("GetPublishedItems")]
        public IEnumerable<BlogItemModel> GetPublishedItems()
        {
            return _data.GetPublishedItems();
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