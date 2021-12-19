using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface IPilotService
    {
        public List<Pilot> GetAll();
        public Pilot GetById(int id);
        public Pilot Add(Pilot pilot);
        public void Delete(int id);
        public void Update(Pilot pilot);
    }
}
