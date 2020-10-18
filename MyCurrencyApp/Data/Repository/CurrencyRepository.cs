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
        public IEnumerable<Currency> Currencys => appDBContent.Currency;

        public Currency getObjectCar(string title) => appDBContent.Currency.FirstOrDefault(p => p.title == title);
    }
}
