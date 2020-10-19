using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Rate>> Rates()
        {
            return await appDBContent.Rate.ToListAsync();
        }

        public async Task<Rate> getObjectRate(DateTime dataRate)
        {
            return await appDBContent.Rate.Where(r => r.dataRate == dataRate).FirstOrDefaultAsync();
        }
    }
}
