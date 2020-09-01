using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.UnitOfWork;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Context;

namespace ProjectStructure.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<TaskDTO>>> GetTasks() {
            try {
                return new JsonResult(await _taskService.GetAllTasks());
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> CreateTask([FromBody] TaskDTO taskDTO) {
            try
            {
                await _taskService.CreateTask(taskDTO);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateTask([FromBody] TaskDTO taskDTO) {
            try
            {
                return Ok(await _taskService.UpdateTask(taskDTO));
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTask(int id) {
            try
            {
                await _taskService.DeleteTask(id);
                return Ok();
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}