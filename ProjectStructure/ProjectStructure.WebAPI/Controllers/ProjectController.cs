using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.UnitOfWork;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Context;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ProjectDTO>>> GetProjects() {
            try
            {
                return new JsonResult(await _projectService.GetAllProjects());
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> CreateProject([FromBody] ProjectDTO projectDTO) {
            try
            {
                await _projectService.CreateProject(projectDTO);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateProject([FromBody] ProjectDTO projectDTO) {
            try
            {
                await _projectService.UpdateProject(projectDTO);
                return Ok();
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProject(int id) {
            try
            {
               await _projectService.DeleteProject(id);
                return Ok();
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}