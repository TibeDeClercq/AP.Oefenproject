using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ICircuitService
    {
        public List<Circuit> GetAll();
        public Circuit GetById(int id);
        public Circuit Add(Circuit circuit);
        public void Delete(int id);
        public void Update(Circuit circuit);
    }
}
