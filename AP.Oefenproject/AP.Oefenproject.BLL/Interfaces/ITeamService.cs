using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ITeamService
    {
        public List<Team> GetAll();
        public Team GetById(int id);
        public Team Add(Team team);
        public void Delete(int id);
        public void Update(Team team);
    }
}
