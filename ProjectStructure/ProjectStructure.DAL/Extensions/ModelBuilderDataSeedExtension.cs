using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Extensions
{
    public static class ModelBuilderDataSeedExtension
    {
        public static void SeedDataContext(this ModelBuilder modelBuilder)
        {
            var projects = new List<Project>
            {
                new Project{
                    Id = 1,
                    AuthorId = 1,
                    CreatedAt = DateTime.Now,
                    Decription = " Some",
                    Name="First project",
                    ProjectDeadline = DateTime.Now.AddDays(5),
                    TeamId = 1

                },
                new Project{
                    Id = 2,
                    AuthorId = 2,
                    CreatedAt = DateTime.Now,
                    Decription = " Some",
                    Name="Second project",
                    ProjectDeadline = DateTime.Now.AddDays(5),
                    TeamId = 2

                }
            };

            var tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    FinishedAt = DateTime.Now.AddDays(4),
                    Description = "Some",
                    Name = "First task",
                    PerfomerId = 1,
                    ProjectId = 1
                },
                new Task
                {
                Id = 2,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Second task",
                PerfomerId = 2,
                ProjectId = 2
                }
            };

            var teams = new List<Team>
            {
                new Team {
                    Id = 1,
                    CreatedAtDate = DateTime.Now,
                    Name = "Team 1"
                },
                new Team
                {
                    Id = 2,
                    CreatedAtDate = DateTime.Now,
                    Name = "Team 2"
                }
            };

            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Denis",
                    LastName = "Pos",
                    Birthday = DateTime.Parse("28.10.2000"),
                    Email = "some",
                    RegisteredAt = DateTime.Parse("12.05.2010"),
                    TeamId = 1
                },
                new User
                {
                    Id = 2,
                    FirstName = "Vasya",
                    LastName = "Ken",
                    Birthday = DateTime.Parse("05.11.2001"),
                    Email = "some",
                    RegisteredAt = DateTime.Parse("12.05.2010"),
                    TeamId = 2
                }
            };

            modelBuilder.Entity<Project>().HasData(projects);
            modelBuilder.Entity<Task>().HasData(tasks);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
