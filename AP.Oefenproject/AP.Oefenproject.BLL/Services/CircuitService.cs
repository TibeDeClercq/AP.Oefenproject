using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.BLL.Interfaces;
using AP.Oefenproject.DAL.Contexts;
using AP.Oefenproject.DAL.Model;
using System.Linq;

namespace AP.Oefenproject.BLL.Services
{
    public class CircuitService : ICircuitService
    {
        private OefenprojectContext _oefenprojectContext;

        public CircuitService(OefenprojectContext oefenprojectContext)
        {
            _oefenprojectContext = oefenprojectContext;
        }

        public List<Circuit> GetAll()
        {
            return _oefenprojectContext.Circuits.ToList();
        }

        public Circuit GetById(int id)
        {
            return _oefenprojectContext.Circuits.Find(id);
        }

        public Circuit Add(Circuit circuit)
        {
            try
            {
                _oefenprojectContext.Circuits.Add(circuit);
                _oefenprojectContext.SaveChanges();
                return circuit;
            } catch(Exception e)
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            var circuit = _oefenprojectContext.Circuits.Find(id);
            if(circuit != null)
            {
                _oefenprojectContext.Remove(circuit);
                _oefenprojectContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("");
            }
        }

        public void Update(Circuit circuit)
        {
            //var circuitFound = _oefenprojectContext.Circuits.Find(circuit.Circuit_id);
            if (circuit != null)
            {
                _oefenprojectContext.Circuits.Update(circuit);
                _oefenprojectContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("");
            }
        }
    }
}
