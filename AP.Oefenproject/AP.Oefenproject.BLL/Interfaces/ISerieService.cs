using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ISerieService
    {
        public List<Serie> GetAll();
        public Serie GetById(int id);
        public Serie Add(Serie serie);
        public void Delete(int id);
        public void Update(Serie serie);
    }
}
