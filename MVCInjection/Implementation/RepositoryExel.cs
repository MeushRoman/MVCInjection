﻿using MVCInjection.Abstract;
using MVCInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInjection.Implementation
{
    public class RepositoryExel : IRepository
    {
        public void AddCity(City city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> All()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public City GetCityById(int id)
        {
            return new City { Id = 1, Name = "Apple", IsCapital = true, population = 500000 };
        }
    }
}