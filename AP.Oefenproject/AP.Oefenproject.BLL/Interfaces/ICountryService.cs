using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;

namespace AP.Oefenproject.BLL.Interfaces
{
    public interface ICountryService
    {
        public List<Country> GetAll();
        public Country GetById(int id);
        public Country Add(Country country);
        public void Delete(int id);
        public void Update(Country country);
    }
}
