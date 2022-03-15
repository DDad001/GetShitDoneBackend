using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetShitDoneBackend.Models
{
    public class ProjectItemModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? DateCreated { get; set; }
        public string? DueDate { get; set; }
        public string? Status { get; set; }
        public int[] MembersId { get; set; }
        public string[]? MembersUsername { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }

        public ProjectItemModel(){}
    }
}