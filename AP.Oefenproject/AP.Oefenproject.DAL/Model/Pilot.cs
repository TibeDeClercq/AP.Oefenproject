using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class Pilot
    {
        #region Properties
        private int pilot_id; //PK

        private int license_nr; //UK

        private string name;

        private string surname;

        private string nickname;

        private string gender;

        private string date_of_birth;

        private int length;

        private int weight;

        private string picture_path;
        #endregion

        #region Getters/setters
        public int Pilot_id
        {
            get { return pilot_id; }
            set { pilot_id = value; }
        }

        public int License_nr
        {
            get { return license_nr; }
            set { license_nr = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Date_of_birth
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Picture_path
        {
            get { return picture_path; }
            set { picture_path = value; }
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
