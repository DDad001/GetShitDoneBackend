using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetShitDoneBackend.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Salt { get; set; }
        public string? Hash { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsSpecialist { get; set; }
        
        public UserModel(){}
    }
}