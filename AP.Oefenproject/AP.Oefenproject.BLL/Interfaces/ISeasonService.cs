using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ISeasonService
    {
        public List<Season> GetAll();
        public Season GetById(int id);
        public Season Add(Season season);
        public void Delete(int id);
        public void Update(Season season);
    }
}
