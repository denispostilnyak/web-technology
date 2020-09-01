using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<TeamDTO>>> GetTeam() {
            try {
                return new JsonResult(await _teamService.GetAllTeams());
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> CreateTeam([FromBody] TeamDTO teamDTO) {
            try
            {
                await _teamService.CreateTeam(teamDTO);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateTeam([FromBody] TeamDTO teamDTO) {
            try
            {
                await _teamService.UpdateTeam(teamDTO);
                return Ok();
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete()]
        public async Task<ActionResult> DeleteTeam(int id) {
            try
            {
               await _teamService.DeleteTeam(id);
                return Ok();
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}