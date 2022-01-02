using System;
using System.Collections.Generic;
using System.Text;

using AP.Oefenproject.DAL.Repositories;
using AP.Oefenproject.DAL.Contexts;

namespace AP.Oefenproject.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private OefenprojectContext _oefenprojectContext;
        
        private ICircuitRepository _circuitRepository;
        //...
        public UnitOfWork(
            OefenprojectContext oefenprojectContext,
            ICircuitRepository circuitRepository
        )
        {
            _oefenprojectContext = oefenprojectContext;
            _circuitRepository = circuitRepository;
        }

        public ICircuitRepository CircuitRepository
        {
            get
            {
                return _circuitRepository;
            }
        }

        public int Commit()
        {
            return _oefenprojectContext.SaveChanges();
        }
    }
}
