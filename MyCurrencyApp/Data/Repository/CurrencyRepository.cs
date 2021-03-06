﻿using Microsoft.EntityFrameworkCore;
using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Models;
using System;
using Microsoft.EntityFrameworkCore;
using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurrencyApp.Data.Repository
{
    public class CurrencyRepository : IRatesCurrency
    {
        private readonly AppDBContent appDBContent;
        public CurrencyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public async Task<IEnumerable<Currency>> AllCurrencys()
        {
            return await appDBContent.Currency.ToListAsync();
        }

        public async Task<Currency> getCurrency(string title)
        {
            return await appDBContent.Currency.Include(e => e.rates).Where(p => p.title == title || p.fullName == title).FirstOrDefaultAsync();
        }
    }
}