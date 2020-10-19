using MyCurrencyApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Models
{
    public class Currency
    {
        public int id { get; set; }
        public int numCode { get; set; }
        public string fullName { get; set; }
        public string title { get; set; }
        public List<Rate> rates { get; set; }
    }
}