using System;
using System.Collections.Generic;
using System.Text;

using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.DAL.Repositories
{
    public interface ICircuitRepository
    {
        public IEnumerable<Circuit> GetAll();
        public Circuit GetById(int id);
        public Circuit Create(Circuit circuit);
        public void Update(Circuit modifiedCircuit);
        public void Delete(int id);

    }
}
