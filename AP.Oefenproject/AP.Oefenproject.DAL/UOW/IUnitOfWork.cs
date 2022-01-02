using System;
using System.Collections.Generic;
using System.Text;

using AP.Oefenproject.DAL.Repositories;

namespace AP.Oefenproject.DAL.UOW
{
    public interface IUnitOfWork
    {
        public int Commit();
        public ICircuitRepository CircuitRepository { get; }
        
        //...

    }
}
