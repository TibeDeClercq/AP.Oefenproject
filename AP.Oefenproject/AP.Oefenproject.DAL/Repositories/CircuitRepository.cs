using System;
using System.Collections.Generic;
using System.Text;

using AP.Oefenproject.DAL.Contexts;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.DAL.Repositories
{
    public class CircuitRepository : ICircuitRepository
    {
        private OefenprojectContext _oefenprojectContext;

        public CircuitRepository(OefenprojectContext oefenprojectContext)
        {
            _oefenprojectContext = oefenprojectContext;
        }

        #region ICircuitRepository implementation
        public IEnumerable<Circuit> GetAll()
        {
            return _oefenprojectContext.Circuits;
        }

        public Circuit GetById(int id)
        {
            return _oefenprojectContext.Circuits.Find(id);
        }

        public Circuit Create(Circuit circuit)
        {
            _oefenprojectContext.Circuits.Add(circuit);
            _oefenprojectContext.SaveChanges();
            return circuit;
        }

        public void Update(Circuit modifiedCircuit)
        {
            _oefenprojectContext.Circuits.Update(modifiedCircuit);
            _oefenprojectContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Circuit circuit = new Circuit() { Circuit_id = id };
            _oefenprojectContext.Remove<Circuit>(circuit);
            _oefenprojectContext.SaveChanges();
        }
        #endregion
    }
}
