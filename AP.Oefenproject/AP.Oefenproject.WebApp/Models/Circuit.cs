using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AP.Oefenproject.WebApp.Models
{
    public class Circuit
    {
        private int circuit_id; //PK

        private int country_id; //FK

        private string circuit_name;

        private string province;

        private string city;

        private string street;

        private string house_number;

        private int length; //in km's

        #region Getters/setters
        [DisplayName("Circuit id")]
        [Required]
        public int Circuit_id
        {
            get { return circuit_id; }
            set { circuit_id = value; }
        }

        [DisplayName("Country id")]
        [Required]
        public int Country_id
        {
            get { return country_id; }
            set { country_id = value; }
        }

        [DisplayName("Circuit name")]
        [Required]
        public string Circuit_name
        {
            get { return circuit_name; }
            set { circuit_name = value; }
        }

        [DisplayName("Province name")]
        [Required]
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        [DisplayName("City name")]
        [Required]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DisplayName("Street name")]
        [Required]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        [DisplayName("House number")]
        [Required]
        public string House_number
        {
            get { return house_number; }
            set { house_number = value; }
        }

        [DisplayName("Track length")]
        [Required]
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
