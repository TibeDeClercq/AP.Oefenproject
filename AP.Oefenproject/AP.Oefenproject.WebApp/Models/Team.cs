using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.Oefenproject.WebApp.Models
{
    public class Team
    {
        private int team_id; //PK

        private string team_name;

        #region Getters/setters
        public int Team_id
        {
            get { return team_id; }
            set { team_id = value; }
        }

        public string Team_name
        {
            get { return team_name; }
            set { team_name = value; }
        }
        #endregion

        #region Relations
        private List<RacePilotTeam> racePilotTeams;

        public List<RacePilotTeam> RacePilotTeams
        {
            get { return racePilotTeams; }
            set { racePilotTeams = value; }
        }
        #endregion
    }
}
