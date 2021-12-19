using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface IRacePilotTeamService
    {
        public List<RacePilotTeam> GetAll();
        public RacePilotTeam GetById(int id);
        public RacePilotTeam Add(RacePilotTeam racePilotTeam);
        public void Delete(int id);
        public void Update(RacePilotTeam racePilotTeam);
    }
}
