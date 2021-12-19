using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class RacePilotTeam
    {
        #region Properties
        private int pilot_id; //PK / FK

        private int race_id; //PK / FK

        private int team_id; //FK
        #endregion

        #region Getters/setters
        public int Pilot_id
        {
            get { return pilot_id; }
            set { pilot_id = value; }
        }

        public int Race_id
        {
            get { return race_id; }
            set { race_id = value; }
        }

        public int Team_id
        {
            get { return team_id; }
            set { team_id = value; }
        }
        #endregion

        #region Relations
        private Pilot pilot;

        private Race race;

        private Team team;

        public Pilot Pilot
        {
            get { return pilot; }
            set { pilot = value; }
        }

        public Race Race
        {
            get { return race; }
            set { race = value; }
        }

        public Team Team
        {
            get { return team; }
            set { team = value; }
        }
        #endregion
    }
}
