using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInjection.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int population { get; set; }
        public bool IsCapital { get; set; }
    }
}