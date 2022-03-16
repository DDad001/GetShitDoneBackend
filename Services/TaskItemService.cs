using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetShitDoneBackend.Models;
using GetShitDoneBackend.Services.Context;

namespace GetShitDoneBackend.Services
{
    public class TaskItemService
    {
         private readonly DataContext _context;
        public TaskItemService(DataContext context)
        {
            _context = context;
        }
        
        public bool AddTaskItem(TaskItemModel newTaskItem)
        {
            _context.Add(newTaskItem);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<TaskItemModel> GetAllTaskItems()
        {
            return _context.TaskItemInfo;
        }

        public TaskItemModel GetTaskItemsByID(int id)
        {
            return _context.TaskItemInfo.SingleOrDefault(item => item.Id == id);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByProjectID(int ProjectID)
        {
            return _context.TaskItemInfo.Where(item => item.ProjectId == ProjectID);
        }

        public IEnumerable<TaskItemModel> GetTaskItemByTitle(string Title)
        {
            return _context.TaskItemInfo.Where(item => item.Title == Title);
        }

        public IEnumerable<TaskItemModel> GetTaskItemByDescription(string Description)
        {
            return _context.TaskItemInfo.Where(item => item.Description == Description);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByDateCreated(string DateCreated)
        {
            return _context.TaskItemInfo.Where(item => item.DateCreated == DateCreated);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByDueDate(string dueDate)
        {
            return _context.TaskItemInfo.Where(item => item.DueDate == dueDate);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByPriority(string priority)
        {
            return _context.TaskItemInfo.Where(item => item.Priority == priority);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByAssignee(string assignee)
        {
            return _context.TaskItemInfo.Where(item => item.Assignees == assignee);
        }

        public IEnumerable<TaskItemModel> GetTaskItemsByStatus(string status)
        {
            return _context.TaskItemInfo.Where(item => item.Status == status);
        }

        public bool UpdateTaskItem(TaskItemModel TaskUpdate)
        {
            _context.Update<TaskItemModel>(TaskUpdate);
            return _context.SaveChanges() != 0;
        }

        public bool DeleteTaskItem(TaskItemModel TaskDelete)
        {
            TaskDelete.IsDeleted = true;
            _context.Update<TaskItemModel>(TaskDelete);
            return _context.SaveChanges() !=0;
           
        }
    }
}