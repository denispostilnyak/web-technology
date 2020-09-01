using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.DAL.Context;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Models.StructureModels;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.Common.Models.StructureModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.UnitOfWork.Interfaces;

namespace ProjectStructure.BL.Services
{
    public class QueriesService : IQueriesService
    {
        private  ProjectStructureContext _context;
        private  List<Project> _projects;
        private  List<User> _users;
        private  List<Team> _teams;
        private  List<DAL.Models.Task> _tasks;
        private readonly IMapper _mapper;

            /// <summary>
            /// Я решил тут не делать через UOF, так как я просто беру информацию, если бы я что-то менял бы в констексте - то да.
            /// </summary>

        public QueriesService(ProjectStructureContext context, IMapper mapper)
        {
            _context = context;
            _projects = _context.Projects.ToList();
            _users = _context.Users.ToList();
            _teams = _context.Teams.ToList();
            _tasks = _context.Tasks.ToList();
            _mapper = mapper;
        }

        public Dictionary<string, int> GetTasksByUser(int id)
        {
            if (_users.FirstOrDefault(user => user.Id == id) == null)
            {
                throw new NotFoundException("user");
            }

            var projects = _context.Projects;
            var userProjects = _projects
                                .Where(project => project.AuthorId == id);
            return userProjects.GroupJoin(_tasks,
                            project => project.Id,
                            task => task.ProjectId,
                            (project, tasks) => (project.Name, tasks.Count()))
                    .ToDictionary(key => key.Name, value => value.Item2);
        }

        public async Task<IEnumerable<TaskDTO>> GetTasksByUserCurrentYear(int id) {
            const int maxNameLenght = 45;

            var usersQueryable = _users.AsQueryable();
            var tasksQueryable = _tasks.AsQueryable();
            if ( await usersQueryable.FirstOrDefaultAsync(user => user.Id == id) == null) {
                throw new NotFoundException("user");
            }
            var result = await tasksQueryable.Where(task => task.PerfomerId == id && task.Name.Length < maxNameLenght)
                .Select(task=>_mapper.Map<TaskDTO>(task)).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<TaskDTO>> GetTasksByUserNameCondition(int id) {
            var usersQueryable = _users.AsQueryable();
            var tasksQueryable = _tasks.AsQueryable();

            if (await usersQueryable.FirstOrDefaultAsync(user => user.Id == id) == null) {
                throw new NotFoundException("user");
            }
            var result = await tasksQueryable.Where(task => task.PerfomerId == id && task.FinishedAt.Year == DateTime.Now.Year).ToListAsync();
            return _mapper.Map<IEnumerable<TaskDTO>>(result);
        }

        public IEnumerable<(int, string, IEnumerable<UserDTO>)> GetTeamsOrderTenYears() {
            const int olderTen = 2010;
            var result = _teams.GroupJoin(_users,
                team => team.Id,
                user => user.TeamId,
                (team, users) => (team.Id, team.Name, users
                        .Where(user => user.Birthday.Year < olderTen)
                        .OrderByDescending(user => user.RegisteredAt)
                        .Select(user => _mapper.Map<UserDTO>(user))
                        
                    ));
            return result;
        }

        public IEnumerable<UserDTO> GetUsersSortedByNameAndTasks() {
            var result = _users.OrderBy(user => user.FirstName).GroupJoin(_tasks,
                user => user.Id,
                task => task.PerfomerId,
                (user, tasks) => {
                    user.Tasks = tasks.OrderByDescending(task => task.Name.Length);
                    return _mapper.Map<UserDTO>(user);
                });
            return result;
        }

        public Common.Models.StructureModels.LastProjectCountAndLongerTasks GetLastProjectCountAndLongerTasks(int userId) {
            var lastProjectStruct = new DAL.Models.StructureModels.LastProjectCountAndLongerTasks();

            if (_users.FirstOrDefault(user => user.Id == userId) == null) {
                throw new NotFoundException("user");
            }

            var res = _users.Where(user => user.Id == userId)
                            .GroupJoin(_projects,
                                        user => user.Id,
                                        project => project.AuthorId,
                                        (user, projects) => {
                                            lastProjectStruct.User = user;
                                            lastProjectStruct.LastProject = projects.OrderByDescending(project => project.CreatedAt)
                                                                                        .FirstOrDefault();
                                            lastProjectStruct.CountTasksPerLastProject = projects.Where(project => project.Id == lastProjectStruct.LastProject.Id)
                                                                                                    .GroupJoin(_tasks,
                                                                                                                project => project.Id,
                                                                                                                task => task.ProjectId,
                                                                                                                (project, tasks) => { return tasks.Count(); }).FirstOrDefault();
                                            return user;
                                        }).GroupJoin(_tasks,
                                                        user => user.Id,
                                                        task => task.PerfomerId,
                                                        (user, tasks) => {
                                                            lastProjectStruct.NotFinishedOrCanceledTasks = tasks
                                             .Where(task => task.State == TaskState.Completed || task.State == TaskState.Canceled).Count();
                                                            lastProjectStruct.LongestTask = tasks.OrderByDescending(task => task.FinishedAt - task.CreatedAt)
                                                                                                   .FirstOrDefault();
                                                            return lastProjectStruct;
                                                        }).FirstOrDefault();
            ///В маппер я добавил свои конфиги на маппинг такого объекта, но если оно неправильно, то тот что внизу вариант работает
            /*var resDTO = new Common.Models.StructureModels.LastProjectCountAndLongerTasks();
            resDTO.CountTasksPerLastProject = res.CountTasksPerLastProject;
            resDTO.User = _mapper.Map<UserDTO>(res.User);
            resDTO.NotFinishedOrCanceledTasks = res.NotFinishedOrCanceledTasks;
            resDTO.LongestTask = _mapper.Map<TaskDTO>(res.LongestTask);
            resDTO.LastProject = _mapper.Map<ProjectDTO>(res.LastProject);

            return resDTO;*/

            return _mapper.Map<Common.Models.StructureModels.LastProjectCountAndLongerTasks>(res);
        }

        public IEnumerable<Common.Models.StructureModels.ProjectLongestAndShortestTaskAndUsersAmount> GetProjectLogestAndShortestTaskAndUsersAmount() {
            var currentProjectLongest = new DAL.Models.StructureModels.ProjectLongestAndShortestTaskAndUsersAmount();

            var res = _projects.GroupJoin(_tasks,
                                            project => project.Id,
                                            task => task.ProjectId,
                                            (project, tasks) => {
                                                currentProjectLongest.Project = project;
                                                currentProjectLongest.LongestTaskByDescription = tasks.OrderByDescending(task => task.Description.Length)
                                                                                                        .FirstOrDefault();
                                                currentProjectLongest.ShortestTaskByName = tasks.OrderBy(task => task.Name.Length)
                                                                                                    .FirstOrDefault();
                                                currentProjectLongest.UsersAmountFilteredByProjectProperties = (project.Decription.Length > 20 || tasks.Count() < 3) ? _teams.Where(team => team.Id == project.TeamId)
                                                                                                                        .GroupJoin(_users,
                                                                                                                                    team => team.Id,
                                                                                                                                    user => user.TeamId,
                                                                                                                                    (team, users) => { return users.Count(); }).FirstOrDefault() : 0;
                                                return currentProjectLongest;
                                            });
            ///А здесь наоборот. Я написал маппер, но он чего-то не работает, посмотрите пожалуйста, и скажите что не так
            var resDTO = new List<Common.Models.StructureModels.ProjectLongestAndShortestTaskAndUsersAmount>();

            foreach (var obj in res)
            {
                var currentIntemDTO = new Common.Models.StructureModels.ProjectLongestAndShortestTaskAndUsersAmount();

                currentIntemDTO.UsersAmountFilteredByProjectProperties = obj.UsersAmountFilteredByProjectProperties;
                currentIntemDTO.ShortestTaskByName = _mapper.Map<TaskDTO>(obj.ShortestTaskByName);
                currentIntemDTO.Project = _mapper.Map<ProjectDTO>(obj.Project);
                currentIntemDTO.LongestTaskByDescription = _mapper.Map<TaskDTO>(obj.LongestTaskByDescription);

                resDTO.Add(currentIntemDTO);
            }
            return resDTO;
        }

        public async Task<IEnumerable<TaskDTO>> GetUnFinishedUserTasks(int userId)
        {
            var usersQueryable = _users.AsQueryable();
            var tasksQueryable = _tasks.AsQueryable();

            if (await usersQueryable.FirstOrDefaultAsync(user => user.Id == userId) == null)
            {
                throw new NotFoundException(typeof(User).ToString());
            }

            return await tasksQueryable.Where(task => task.PerfomerId == userId && task.State != TaskState.Completed)
                .Select(task => _mapper.Map<TaskDTO>(task)).ToListAsync();
        }

        /// <summary>
        /// This methods just for testing
        /// </summary>
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void AddPoject(Project project)
        {
            _projects.Add(project);
        }

        public void AddTeam(Team team)
        {
            _teams.Add(team);
        }

        public void AddTask(DAL.Models.Task task)
        {
            _tasks.Add(task);
        }
    }
}
