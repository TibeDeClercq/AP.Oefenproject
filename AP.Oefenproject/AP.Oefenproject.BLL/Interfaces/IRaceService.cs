using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface IRaceService
    {
        public List<Race> GetAll();
        public Race GetById(int id);
        public Race Add(Race race);
        public void Delete(int id);
        public void Update(Race race);
    }
}
