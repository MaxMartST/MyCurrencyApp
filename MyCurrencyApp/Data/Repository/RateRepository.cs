using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Repository
{
    public class RateRepository : IAllRates
    {
        private readonly AppDBContent appDBContent;

        public RateRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public Rate getObjectrat(DateTime dataRate) => appDBContent.Rate.FirstOrDefault(r => r.dataRate == dataRate);
    }
}
