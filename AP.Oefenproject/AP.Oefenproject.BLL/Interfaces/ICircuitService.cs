using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ICircuitService
    {
        public IEnumerable<Circuit> GetAll();
        public Circuit GetById(int id);
        public Circuit Create(Circuit circuit);
        public void Delete(int id);
        public void Update(Circuit circuit);
    }
}
