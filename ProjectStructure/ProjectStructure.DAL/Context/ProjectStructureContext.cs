using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProjectStructure.DAL.Extensions;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Context
{
    public class ProjectStructureContext : DbContext
    {
        public ProjectStructureContext(DbContextOptions<ProjectStructureContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderDataSeedExtension.SeedDataContext(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
