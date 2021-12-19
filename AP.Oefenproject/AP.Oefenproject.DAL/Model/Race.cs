using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class Race
    {
        #region Properties
        private int race_id; //PK

        private int season_id; //FK

        private int circuit_id; //FK

        private string race_name;

        private string start_date;

        private string end_date;
        #endregion

        #region Getters/setters
        public int Race_id
        {
            get { return race_id; }
            set { race_id = value; }
        }

        public int Season_id
        {
            get { return season_id; }
            set { season_id = value; }
        }

        public int Circuit_id
        {
            get { return circuit_id; }
            set { circuit_id = value; }
        }

        public string Race_name
        {
            get { return race_name; }
            set { race_name = value; }
        }

        public string Start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public string End_date
        {
            get { return end_date; }
            set { end_date = value; }
        }
        #endregion

        #region Relations
        private Season season;

        private Circuit circuit;

        private List<RacePilotTeam> racePilotTeams;

        public Season Season
        {
            get { return season; }
            set { season = value; }
        }

        public Circuit Circuit
        {
            get { return circuit; }
            set { circuit = value; }
        }

        public List<RacePilotTeam> RacePilotTeams
        {
            get { return racePilotTeams; }
            set { racePilotTeams = value; }
        }
        #endregion
    }
}
