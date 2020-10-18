using Microsoft.EntityFrameworkCore;
using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Repository
{
    public class CurrencyRepository : IAllCurrencys
    {
        private readonly AppDBContent appDBContent;
        public CurrencyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public async Task<IEnumerable<Currency>> Currencys()
        {
            return await appDBContent.Currency.ToListAsync();
        }

        public async Task<Currency> getObjectCurrency(string title)
        {
            return await appDBContent.Currency.Where(p => p.title == title).FirstOrDefaultAsync();
        }
    }
}
