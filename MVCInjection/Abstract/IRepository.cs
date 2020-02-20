using MVCInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInjection.Abstract
{
    public interface IRepository
    {
        void AddCity(City city);
        IEnumerable<City> FindByName(string name);
        IEnumerable<City> All();
        City GetCityById(int id);
        bool Delete(int Id);
    }
}