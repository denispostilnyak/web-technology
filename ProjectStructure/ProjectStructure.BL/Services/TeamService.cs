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
    public class TeamService : ITeamService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Team> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public TeamService(IUnitOfWork unitOfWork, IMapper mapper) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Set<Team>();
        }
        public async System.Threading.Tasks.Task CreateTeam(TeamDTO teamDTO) {
            var team = _mapper.Map<Team>(teamDTO);
            if (team.Id < 0)
            {
                throw new Exception();
            }
            await _repository.Create(team);
            await _unitOfWork.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteTeam(int teamId) {
            await _repository.Delete(teamId);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamDTO>> GetAllTeams() {
            var result = await _repository.Get();
            return _mapper.Map<IEnumerable<TeamDTO>>(result);
        }

        public async System.Threading.Tasks.Task UpdateTeam(TeamDTO teamDTO) {
            var team = _mapper.Map<Team>(teamDTO);
            _repository.Update(team);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
