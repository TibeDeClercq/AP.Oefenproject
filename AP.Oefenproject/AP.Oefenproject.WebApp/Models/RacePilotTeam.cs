using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.Oefenproject.WebApp.Models
{
    public class RacePilotTeam //Hoe PK's combineren voor CRUD acties?
    {
        private int pilot_id; //PK / FK

        private int race_id; //PK / FK

        private int team_id; //FK

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
