using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.Oefenproject.WebApp.Models
{
    public class Country
    {
        private int country_id; //PK

        private string country_name;

        #region Getters/setters
        public int Country_id
        {
            get { return country_id; }
            set { country_id = value; }
        }

        public string Country_name
        {
            get { return country_name; }
            set { country_name = value; }
        }
        #endregion

        #region Relations
        private List<Circuit> circuits;

        public List<Circuit> Circuits
        {
            get { return circuits; }
            set { circuits = value; }
        }
        #endregion
    }
}
