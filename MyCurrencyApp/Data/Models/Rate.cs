using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Models
{
    public class Rate
    {
        public int id { get; set; }
        public DateTime dataRate { get; set; }
        public decimal value { get; set; }//курс
        public int nominal { get; set; }//номинал 
        //public virtual Currency Currency { get; set; }
        //значит что мы создаём объект на основе Currency
        //то есть со всему значениями, которые есть в Currency
    }
}
