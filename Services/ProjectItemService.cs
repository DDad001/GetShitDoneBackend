using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // Needs some working on
        public ProjectItemModel GetProjectItemByAMemberUsername(string memberUsername)
        {
            //"Tag1, Tag2, Tag3,Tag4"
            List<ProjectItemModel> AllMembersByUsername = new List<ProjectItemModel>();//[]
            var allItems = GetAllProjectItem().ToList();//{Tag:"Tag1, Tag2",Tag:"Tag2",Tag:"tag3"}
            for(int i=0; i < allItems.Count; i++)
            {
                ProjectItemModel Item = allItems[i];//{Tag:"Tag1, Tag2"}
                var itemArr = Item.MembersUsername.Split(",");//["Tag1","Tag2"]
                for(int j = 0; j < itemArr.Length; j++)
                {   //Tag1 j = 0
                    //Tag2 j = 1
                    if(itemArr[j].Contains(memberUsername))
                    {// Tag1               Tag1
                        AllMembersByUsername.Add(Item);//{Tag:"Tag1, Tag2"}
                    }
                }
            }
            return AllMembersByUsername;
        }

        public IEnumerable<ProjectItemModel> GetDeletedProjectItems()
        {
            return _context.ProjectItemInfo.Where(item => item.IsDeleted);
        }

        public IEnumerable<ProjectItemModel> GetArchivedProjectItems()
        {
            return _context.ProjectItemInfo.Where(item => item.IsArchived);
        }

        public bool UpdateProjectItem(ProjectItemModel updatedProject)
        {
            _context.Update<ProjectItemModel>(updatedProject);
            return _context.SaveChanges() != 0;
        }
    }
}