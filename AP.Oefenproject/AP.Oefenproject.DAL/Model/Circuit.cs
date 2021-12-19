using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Oefenproject.DAL.Model
{
    public class Circuit
    {
        #region Properties
        private int circuit_id; //PK

        private int country_id; //FK

        private string circuit_name;

        private string province;

        private string city;

        private string street;

        private string house_number;

        private int length; //in km's
        #endregion

        #region Getters/setters
        public int Circuit_id
        {
            get { return circuit_id; }
            set { circuit_id = value; }
        }

        public int Country_id
        {
            get { return country_id; }
            set { country_id = value; }
        }

        public string Circuit_name
        {
            get { return circuit_name; }
            set { circuit_name = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House_number
        {
            get { return house_number; }
            set { house_number = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        #endregion

        #region Relations
        private List<Race> races;

        private Country country;

        public List<Race> Races
        {
            get { return races; }
            set { races = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion
    }
}
