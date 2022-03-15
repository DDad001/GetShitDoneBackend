using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetShitDoneBackend.Models;
using GetShitDoneBackend.Services.Context;

namespace GetShitDoneBackend.Services
{
    public class ProjectItemService
    {
        private readonly DataContext _context;
        public ProjectItemService(DataContext context)
        {
            _context = context;
        }
        
        public bool AddProjectItem(ProjectItemModel newProjectItem)
        {
            _context.Add(newProjectItem);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<ProjectItemModel> GetAllProjectItem()
        {
            return _context.ProjectItemInfo;
        }

        public ProjectItemModel GetItemsById(int id)
        {
            return _context.ProjectItemInfo.SingleOrDefault(item => item.Id == id);
        }

        public IEnumerable<ProjectItemModel> GetItemsByUserId(int userId)
        {
            return _context.ProjectItemInfo.Where(item => item.UserId == userId);
        }


        public ProjectItemModel GetProjectItemByTitle(string title)
        {
            return _context.ProjectItemInfo.Where(item => item.Title == title);
        }

        public ProjectItemModel GetProjectItemByDescription(string description)
        {
            return _context.ProjectItemInfo.Where(item => item.Description == description);
        }

        public ProjectItemModel GetProjectItemByDateCreated(string dateCreated)
        {
            return _context.ProjectItemInfo.Where(item => item.DateCreated == dateCreated);
        }

        public ProjectItemModel GetProjectItemByDueDate(string dueDate)
        {
            return _context.ProjectItemInfo.Where(item => item.DueDate == dueDate);
        }

        public ProjectItemModel GetProjectItemStatus(string status)
        {
            return _context.ProjectItemInfo.Where(item => item.Status == status);
        }

        public ProjectItemModel GetProjectItemByAMemberId(int memberId)
        {
            return _context.ProjectItemInfo.Where(item => item.UserId == memberId);
        }

        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemByAMemberUsername(memberUsername);
        }

        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            return _data.GetProjectItemByAMemberUsername(memberUsername);
        }

        public IEnumerable<ProjectItemModel> GetDeletedProjectItems()
        {
            return _data.GetDeletedProjectItems();
        }

        public IEnumerable<ProjectItemModel> GetArchivedProjectItems()
        {
            return _data.GetArchivedProjectItems();
        }

        public bool UpdateProjectItem(ProjectItemModel updatedProject)
        {
            return _data.UpdateProjectItem(updatedProject);
        }
    }
}