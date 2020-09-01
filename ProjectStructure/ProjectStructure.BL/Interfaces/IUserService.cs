using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.BL.Interfaces
{
    public interface IUserService 
    {
        Task<IEnumerable<UserDTO>> GetAllUsers();

        Task<UserDTO> GetById(int id);
        Task CreateUser(UserDTO user);
        Task UpdateUser(UserDTO user);
        Task DeleteUser(int userId);
    }
}
