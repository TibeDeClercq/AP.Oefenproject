using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using AP.Oefenproject.BLL.Interfaces;
using AP.Oefenproject.DAL.Contexts;
using AP.Oefenproject.DAL.Model;
using AP.Oefenproject.DAL.UOW;

namespace AP.Oefenproject.BLL.Services
{
    public class CircuitService : ICircuitService
    {
        private IUnitOfWork _unitOfWork;

        public CircuitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Circuit> GetAll()
        {
            return _unitOfWork.CircuitRepository.GetAll();
        }

        public Circuit GetById(int id)
        {
            return _unitOfWork.CircuitRepository.GetById(id);
        }

        public Circuit Create(Circuit circuit)
        {
            try
            {
                circuit = _unitOfWork.CircuitRepository.Create(circuit);
                //extra Creates voor onderliggende relaties (bv lijst van races toevoegen indien meegegeven)

                //foreach(Race race in circuit.Races)
                //{
                //    _unitOfWork.RaceRepository.Create(race);
                //}

                _unitOfWork.Commit();
                return circuit;
            } catch(Exception e)
            {
                return null;
            }
        }

        public void Update(Circuit circuit)
        {
            try
            {
                _unitOfWork.CircuitRepository.Update(circuit);
                _unitOfWork.Commit();
            }
            catch(Exception e)
            {
                throw new KeyNotFoundException("");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _unitOfWork.CircuitRepository.Delete(id);
                _unitOfWork.Commit();
            }
            catch(Exception e)
            {
                throw new KeyNotFoundException("");
            }
        }
    }
}
