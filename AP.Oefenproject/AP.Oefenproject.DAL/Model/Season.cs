using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class Season
    {
        #region Properties
        private int season_id; //PK

        private int serie_id; //FK

        private string season_name;

        private string start_date;

        private string end_date;

        private bool active;
        #endregion

        #region Getters/setters
        public int Season_id
        {
            get { return season_id; }
            set { season_id = value; }
        }

        public int Serie_id
        {
            get { return serie_id; }
            set { serie_id = value; }
        }

        public string Season_name
        {
            get { return season_name; }
            set { season_name = value; }
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

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        #endregion

        #region Relations
        private Serie serie;

        private List<Race> races;

        public Serie Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        public List<Race> Races
        {
            get { return races; }
            set { races = value; }
        }
        #endregion
    }
}
