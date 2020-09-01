using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.Services;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.Common.Models.StructureModels;
using ProjectStructure.DAL.Context;

namespace ProjectStructure.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        private readonly IQueriesService _service;
        public QueriesController(IQueriesService service)
        {
            _service = service;
        }
        [HttpGet("tasksByUser/{id}")]
        public ActionResult<Dictionary<string, int>> GetTasksByUser(int id) {
            try
            {
                var result = _service.GetTasksByUser(id);
                return new JsonResult(result);
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("unFinishedUserTasks/{id}")]
        public async Task<ActionResult<IEnumerable<TaskDTO>>> GetUnFinishedUserTasks(int id) {
            try {
                var result = await _service.GetUnFinishedUserTasks(id);
                return Ok(result);
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("tasksByUserPropertyName/{id}")]
        public async Task<ActionResult<IEnumerable<TaskDTO>>> GetTasksByUserPropertyName(int id)
        {
            try {
                var result = await _service.GetTasksByUserNameCondition(id);

                return new JsonResult(result);
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("tasksByUserAndYear/{id}")]
        public async Task<ActionResult<IEnumerable<TaskDTO>>> GetTasksByUserAndYear(int id)
        {
            try {
                var result = await _service.GetTasksByUserCurrentYear(id);

                return new JsonResult(result);
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("teamsOrderTenYears")]
        public ActionResult<IEnumerable<(int, string, List<UserDTO>)>> GetTeamsOrderTenYears()
        {
            try {
                var result = _service.GetTeamsOrderTenYears();

                return new JsonResult(result);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("usersSortedByProperties")]
        public ActionResult<IEnumerable<UserDTO>> GetUsersSortedByNameAndTasks()
        {
            try {
                var result = _service.GetUsersSortedByNameAndTasks();

                return new JsonResult(result);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("lastProjectCountAndLongerTasks/{id}")]
        public ActionResult<LastProjectCountAndLongerTasks> GetLastProjectCountAndLongerTasks(int userId)
        {
            try {
                var result = _service.GetLastProjectCountAndLongerTasks(userId);
                return new JsonResult(result);
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("projectLongestAndShortestTaskAndUsersAmount")]
        public ActionResult<IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount>> GetProjectLongestAndShortestTaskAndUsersAmount()
        {
            try {
                var result = _service.GetProjectLogestAndShortestTaskAndUsersAmount();

                return new JsonResult(result);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}