using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class Team
    {
        #region Properties
        private int team_id; //PK

        private string team_name;
        #endregion

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
