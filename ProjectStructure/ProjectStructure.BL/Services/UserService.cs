using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Context;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BL.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<User> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Set<User>();
        }
        public async System.Threading.Tasks.Task CreateUser(UserDTO userDTO) {
            var user = _mapper.Map<User>(userDTO);

            await _repository.Create(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteUser(int userId) {
            await _repository.Delete(userId);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers() {
            var result = await _repository.Get();
            return _mapper.Map<IEnumerable<UserDTO>>(result);
        }

        public async Task<UserDTO> GetById(int id)
        {
            return _mapper.Map<UserDTO>(await _repository.GetById(id));
        }

        public async System.Threading.Tasks.Task UpdateUser(UserDTO userDTO) {
            var user = _mapper.Map<User>(userDTO);

            _repository.Update(user);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
