using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetShitDoneBackend.Models
{
    public class TaskItemModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? DateCreated { get; set; }
        public string? DueDate { get; set; }
        public string? Priority { get; set; }
        public string? Assignees { get; set; }
        public string? Status { get; set; }
        public bool IsDeleted { get; set; }

        public TaskItemModel(){}
    }
}