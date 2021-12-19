using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.Oefenproject.WebApp.Models
{
    public class Serie
    {
        private int serie_id; //PK

        private string serie_name;

        private string start_date;

        private string end_date;

        private int sort_order;

        #region Getters/setters
        public int Serie_id
        {
            get { return serie_id; }
            set { serie_id = value; }
        }

        public string Serie_name
        {
            get { return serie_name; }
            set { serie_name = value; }
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

        public int Sort_order
        {
            get { return sort_order; }
            set { sort_order = value; }
        }
        #endregion

        #region Relations
        private List<Season> seasons;

        public List<Season> Seasons
        {
            get { return seasons; }
            set { seasons = value; }
        }
        #endregion
    }
}
