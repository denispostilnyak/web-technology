using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.DAL.Context;
using ProjectStructure.DAL.Models;
using ProjectStructure.BL.UnitOfWork;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers() {
            try {
                return new JsonResult(await _userService.GetAllUsers());
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> CreateUser([FromBody] UserDTO userDTO) {
            try
            {
               await _userService.CreateUser(userDTO);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateUser([FromBody] UserDTO userDTO) {
            try
            {
                await _userService.UpdateUser(userDTO);
                return Ok();
            } catch (ArgumentException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id) {
            try
            {
                await _userService.DeleteUser(id);
                return Ok();
            } catch (NotFoundException e) {
                return NotFound(e.Message);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}