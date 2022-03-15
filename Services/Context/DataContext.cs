using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetShitDoneBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace GetShitDoneBackend.Services.Context
{
    public class DataContext : DbContext 
    {
        public DbSet<UserModel> UserInfo { get; set;}
        public DbSet<ProjectItemModel> ProjectItemInfo { get; set; }
        public DbSet<TaskItemModel> TaskItemInfo { get; set; }
        public DataContext(DbContextOptions options ): base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}