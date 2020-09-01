using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.BL.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDTO>> GetAllTeams();

        Task CreateTeam(TeamDTO team);
        Task UpdateTeam(TeamDTO team);
        Task DeleteTeam(int teamId);
    }
}
